namespace BUX.Runtime.Progression
{
    public sealed class BUXRewardService
    {
        public BUXWallet Wallet { get; } = new BUXWallet();

        public void Grant(BUXRewardGrant grant)
        {
            if (grant == null)
            {
                return;
            }

            Wallet.Coins += ClampNonNegative(grant.Coins);
            Wallet.Stars += ClampNonNegative(grant.Stars);
            Wallet.Trophies += ClampNonNegative(grant.Trophies);
            Wallet.HoneyTokens += ClampNonNegative(grant.HoneyTokens);
            Wallet.CosmeticShards += ClampNonNegative(grant.CosmeticShards);
            Wallet.BoosterFragments += ClampNonNegative(grant.BoosterFragments);
        }

        private static int ClampNonNegative(int value)
        {
            return value < 0 ? 0 : value;
        }
    }
}
