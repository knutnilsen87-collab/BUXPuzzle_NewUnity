using System;
using BUX.Runtime.Core;

namespace BUX.Runtime.Levels
{
    [Serializable]
    public sealed class BUXLevelSpec
    {
        public int LevelId;
        public string WorldId;
        public int Width = 8;
        public int Height = 8;
        public int Seed;
        public int MoveLimit;
        public int DifficultyScore;
        public TileId PrimaryTileObjective;
        public int PrimaryTarget;
        public BlockerKind IntroducedBlocker;
    }
}
