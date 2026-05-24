namespace BUX.Runtime.Services
{
    public sealed class BUXSameBoardChallengeService
    {
        public BUXChallengeConfig CreateChallenge(int levelId, int playerSeed)
        {
            var deterministicSeed = unchecked(levelId * 73856093 ^ playerSeed * 19349663);
            return new BUXChallengeConfig
            {
                ChallengeId = $"level_{levelId}_{deterministicSeed}",
                LevelId = levelId,
                BoardSeed = deterministicSeed,
                FairMode = true
            };
        }
    }
}
