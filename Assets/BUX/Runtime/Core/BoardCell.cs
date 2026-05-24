using System;

namespace BUX.Runtime.Core
{
    [Serializable]
    public struct BoardCell
    {
        public TileId Tile;
        public BlockerKind Blocker;
        public int BlockerHp;
        public bool IsActive;

        public bool HasTile => Tile != TileId.None;
        public bool IsBlocked => Blocker != BlockerKind.None && BlockerHp > 0;
        public bool IsSwappable => IsActive && HasTile && !IsBlocked;

        public static BoardCell Empty()
        {
            return new BoardCell
            {
                Tile = TileId.None,
                Blocker = BlockerKind.None,
                BlockerHp = 0,
                IsActive = true
            };
        }
    }
}
