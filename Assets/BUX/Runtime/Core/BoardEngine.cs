using System.Collections.Generic;

namespace BUX.Runtime.Core
{
    public sealed class BoardEngine
    {
        private static readonly TileId[] SpawnTiles =
        {
            TileId.RedBerry,
            TileId.Blueberry,
            TileId.GreenLeaf,
            TileId.PinkFlower,
            TileId.WhiteDaisy,
            TileId.Mushroom,
            TileId.Acorn
        };

        private readonly SeededRandom _random;
        private readonly BoardCell[,] _cells;

        public int Width { get; }
        public int Height { get; }

        public BoardEngine(int width, int height, int seed)
        {
            Width = width;
            Height = height;
            _random = new SeededRandom(seed);
            _cells = new BoardCell[width, height];
            FillInitialBoard();
            EnsureHasExecutableMove();
        }

        public BoardCell GetCell(BoardCoord coord)
        {
            return _cells[coord.X, coord.Y];
        }

        public void SetBlocker(BoardCoord coord, BlockerKind blocker, int hp)
        {
            if (!InBounds(coord))
            {
                return;
            }

            var cell = _cells[coord.X, coord.Y];
            cell.Blocker = blocker;
            cell.BlockerHp = hp;
            _cells[coord.X, coord.Y] = cell;
            EnsureHasExecutableMove();
        }

        public bool InBounds(BoardCoord coord)
        {
            return coord.X >= 0 && coord.Y >= 0 && coord.X < Width && coord.Y < Height;
        }

        public bool CanPlayerSwap(BoardCoord a, BoardCoord b)
        {
            if (!InBounds(a) || !InBounds(b))
            {
                return false;
            }

            if (a.ManhattanDistance(b) != 1)
            {
                return false;
            }

            if (!_cells[a.X, a.Y].IsSwappable || !_cells[b.X, b.Y].IsSwappable)
            {
                return false;
            }

            SwapTiles(a, b);
            var createsMatch = HasMatchAt(a) || HasMatchAt(b);
            SwapTiles(a, b);
            return createsMatch;
        }

        public int ValidMoveCount()
        {
            var count = 0;
            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    var origin = new BoardCoord(x, y);
                    if (CanPlayerSwap(origin, new BoardCoord(x + 1, y)))
                    {
                        count++;
                    }

                    if (CanPlayerSwap(origin, new BoardCoord(x, y + 1)))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public bool HasAnyValidMove()
        {
            return ValidMoveCount() > 0;
        }

        public ResolveTrace TrySwapAndResolve(BoardCoord a, BoardCoord b)
        {
            if (!InBounds(a) || !InBounds(b))
            {
                return Reject("out_of_bounds");
            }

            if (a.ManhattanDistance(b) != 1)
            {
                return Reject("not_adjacent");
            }

            if (!_cells[a.X, a.Y].IsSwappable || !_cells[b.X, b.Y].IsSwappable)
            {
                return Reject("blocked_or_non_swappable");
            }

            if (!CanPlayerSwap(a, b))
            {
                return Reject("no_match");
            }

            SwapTiles(a, b);
            var trace = new ResolveTrace { Accepted = true };
            ResolveBoard(trace);
            EnsureHasExecutableMove();
            return trace;
        }

        private static ResolveTrace Reject(string reason)
        {
            return new ResolveTrace
            {
                Accepted = false,
                RejectReason = reason
            };
        }

        private void FillInitialBoard()
        {
            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    _cells[x, y] = BoardCell.Empty();
                    _cells[x, y].Tile = PickNonMatchingTile(x, y);
                }
            }
        }

        private TileId PickNonMatchingTile(int x, int y)
        {
            for (var attempt = 0; attempt < 24; attempt++)
            {
                var tile = SpawnTiles[_random.Range(0, SpawnTiles.Length)];
                if (!WouldCreateImmediateMatch(x, y, tile))
                {
                    return tile;
                }
            }

            return SpawnTiles[_random.Range(0, SpawnTiles.Length)];
        }

        private bool WouldCreateImmediateMatch(int x, int y, TileId tile)
        {
            if (x >= 2 && _cells[x - 1, y].Tile == tile && _cells[x - 2, y].Tile == tile)
            {
                return true;
            }

            return y >= 2 && _cells[x, y - 1].Tile == tile && _cells[x, y - 2].Tile == tile;
        }

        private bool HasMatchAt(BoardCoord coord)
        {
            var cell = _cells[coord.X, coord.Y];
            if (!cell.IsActive || cell.Tile == TileId.None || cell.IsBlocked)
            {
                return false;
            }

            return CountLine(coord, 1, 0) + CountLine(coord, -1, 0) + 1 >= 3 ||
                   CountLine(coord, 0, 1) + CountLine(coord, 0, -1) + 1 >= 3;
        }

        private int CountLine(BoardCoord start, int dx, int dy)
        {
            var tile = _cells[start.X, start.Y].Tile;
            var count = 0;
            var x = start.X + dx;
            var y = start.Y + dy;
            while (x >= 0 && y >= 0 && x < Width && y < Height)
            {
                var cell = _cells[x, y];
                if (cell.Tile != tile || cell.IsBlocked)
                {
                    break;
                }

                count++;
                x += dx;
                y += dy;
            }

            return count;
        }

        private void ResolveBoard(ResolveTrace trace)
        {
            for (var guard = 0; guard < 32; guard++)
            {
                var matches = FindMatches();
                if (matches.Count == 0)
                {
                    return;
                }

                trace.ScoreDelta += matches.Count * 10;
                trace.Steps.Add(new ResolveStep { Kind = "clear", Cells = new List<BoardCoord>(matches) });
                foreach (var coord in matches)
                {
                    DamageAdjacentBlockers(coord, trace);
                    var cell = _cells[coord.X, coord.Y];
                    cell.Tile = TileId.None;
                    _cells[coord.X, coord.Y] = cell;
                }

                DropAndSpawn(trace);
            }
        }

        private HashSet<BoardCoord> FindMatches()
        {
            var result = new HashSet<BoardCoord>();
            for (var y = 0; y < Height; y++)
            {
                ScanLine(result, y, true);
            }

            for (var x = 0; x < Width; x++)
            {
                ScanLine(result, x, false);
            }

            return result;
        }

        private void ScanLine(HashSet<BoardCoord> result, int fixedIndex, bool horizontal)
        {
            var runTile = TileId.None;
            var runStart = 0;
            var runLength = 0;
            var length = horizontal ? Width : Height;

            for (var i = 0; i <= length; i++)
            {
                var tile = TileId.None;
                if (i < length)
                {
                    var cell = horizontal ? _cells[i, fixedIndex] : _cells[fixedIndex, i];
                    if (cell.IsSwappable)
                    {
                        tile = cell.Tile;
                    }
                }

                if (i < length && tile != TileId.None && tile == runTile)
                {
                    runLength++;
                    continue;
                }

                if (runTile != TileId.None && runLength >= 3)
                {
                    for (var j = runStart; j < runStart + runLength; j++)
                    {
                        result.Add(horizontal ? new BoardCoord(j, fixedIndex) : new BoardCoord(fixedIndex, j));
                    }
                }

                runTile = tile;
                runStart = i;
                runLength = tile == TileId.None ? 0 : 1;
            }
        }

        private void DamageAdjacentBlockers(BoardCoord coord, ResolveTrace trace)
        {
            DamageBlocker(new BoardCoord(coord.X + 1, coord.Y), trace);
            DamageBlocker(new BoardCoord(coord.X - 1, coord.Y), trace);
            DamageBlocker(new BoardCoord(coord.X, coord.Y + 1), trace);
            DamageBlocker(new BoardCoord(coord.X, coord.Y - 1), trace);
        }

        private void DamageBlocker(BoardCoord coord, ResolveTrace trace)
        {
            if (!InBounds(coord))
            {
                return;
            }

            var cell = _cells[coord.X, coord.Y];
            if (!cell.IsBlocked)
            {
                return;
            }

            cell.BlockerHp--;
            if (cell.BlockerHp <= 0)
            {
                cell.Blocker = BlockerKind.None;
                cell.BlockerHp = 0;
            }

            _cells[coord.X, coord.Y] = cell;
            trace.Steps.Add(new ResolveStep { Kind = "blocker_hit", Cells = new List<BoardCoord> { coord } });
        }

        private void DropAndSpawn(ResolveTrace trace)
        {
            for (var x = 0; x < Width; x++)
            {
                var writeY = 0;
                for (var y = 0; y < Height; y++)
                {
                    if (!_cells[x, y].IsActive || _cells[x, y].IsBlocked)
                    {
                        writeY = y + 1;
                        continue;
                    }

                    if (_cells[x, y].Tile == TileId.None)
                    {
                        continue;
                    }

                    if (writeY != y)
                    {
                        var moved = _cells[x, y].Tile;
                        _cells[x, writeY].Tile = moved;
                        _cells[x, y].Tile = TileId.None;
                    }

                    writeY++;
                }

                for (var y = writeY; y < Height; y++)
                {
                    if (_cells[x, y].IsActive && !_cells[x, y].IsBlocked)
                    {
                        _cells[x, y].Tile = SpawnTiles[_random.Range(0, SpawnTiles.Length)];
                    }
                }
            }

            trace.Steps.Add(new ResolveStep { Kind = "drop_spawn" });
        }

        private void EnsureHasExecutableMove()
        {
            if (HasAnyValidMove())
            {
                return;
            }

            for (var attempt = 0; attempt < 24; attempt++)
            {
                ShuffleMovableTiles();
                if (HasAnyValidMove())
                {
                    return;
                }
            }

            RebuildMovableTiles();
            if (!HasAnyValidMove())
            {
                throw new System.InvalidOperationException("Unable to create a board with an executable move.");
            }
        }

        private void ShuffleMovableTiles()
        {
            var coords = new List<BoardCoord>();
            var tiles = new List<TileId>();
            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    var coord = new BoardCoord(x, y);
                    if (!_cells[x, y].IsSwappable)
                    {
                        continue;
                    }

                    coords.Add(coord);
                    tiles.Add(_cells[x, y].Tile);
                }
            }

            for (var i = tiles.Count - 1; i > 0; i--)
            {
                var j = _random.Range(0, i + 1);
                (tiles[i], tiles[j]) = (tiles[j], tiles[i]);
            }

            for (var i = 0; i < coords.Count; i++)
            {
                var coord = coords[i];
                _cells[coord.X, coord.Y].Tile = tiles[i];
            }
        }

        private void RebuildMovableTiles()
        {
            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    if (_cells[x, y].IsActive && !_cells[x, y].IsBlocked)
                    {
                        _cells[x, y].Tile = PickNonMatchingTile(x, y);
                    }
                }
            }
        }

        private void SwapTiles(BoardCoord a, BoardCoord b)
        {
            (_cells[a.X, a.Y].Tile, _cells[b.X, b.Y].Tile) = (_cells[b.X, b.Y].Tile, _cells[a.X, a.Y].Tile);
        }
    }
}
