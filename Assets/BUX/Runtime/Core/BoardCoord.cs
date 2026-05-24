using System;

namespace BUX.Runtime.Core
{
    [Serializable]
    public readonly struct BoardCoord : IEquatable<BoardCoord>
    {
        public readonly int X;
        public readonly int Y;

        public BoardCoord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int ManhattanDistance(BoardCoord other)
        {
            return System.Math.Abs(X - other.X) + System.Math.Abs(Y - other.Y);
        }

        public bool Equals(BoardCoord other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is BoardCoord other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
