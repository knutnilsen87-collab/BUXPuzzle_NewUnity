using System;

namespace BUX.Runtime.Progression
{
    [Serializable]
    public sealed class BUXRewardGrant
    {
        public string Source;
        public int Coins;
        public int Stars;
        public int Trophies;
        public int HoneyTokens;
        public int CosmeticShards;
        public int BoosterFragments;
    }
}
