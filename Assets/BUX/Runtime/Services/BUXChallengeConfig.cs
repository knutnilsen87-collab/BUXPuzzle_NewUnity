using System;

namespace BUX.Runtime.Services
{
    [Serializable]
    public sealed class BUXChallengeConfig
    {
        public string ChallengeId;
        public int LevelId;
        public int BoardSeed;
        public string LevelConfigVersion = "levels_v1";
        public string ScoringVersion = "scoring_v1";
        public string TileRuleVersion = "tile_rules_v1";
        public bool FairMode = true;
    }
}
