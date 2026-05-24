using System;
using System.IO;
using BUX.Runtime.Core;
using BUX.Runtime.Gameplay;
using BUX.Runtime.Levels;
using BUX.Runtime.Progression;
using BUX.Runtime.Services;
using UnityEditor;
using UnityEngine;

namespace BUX.Editor.Validation
{
    public static class BUXProductionSkeletonValidation
    {
        private const string ReportPath = "bux_production_skeleton_validation_report.txt";

        [MenuItem("BUX/Validation/Run Production Skeleton Validation")]
        public static void RunAndExit()
        {
            try
            {
                Validate();
                File.WriteAllText(ReportPath, "# bux_production_skeleton_validation_report\n\n- status: pass\n- generated_at: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                UnityEditor.EditorApplication.Exit(0);
            }
            catch (Exception ex)
            {
                File.WriteAllText(ReportPath, "# bux_production_skeleton_validation_report\n\n- status: fail\n- generated_at: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n- error: " + ex + "\n");
                Debug.LogException(ex);
                UnityEditor.EditorApplication.Exit(1);
            }
        }

        private static void Validate()
        {
            var levels = BUXLaunchLevelCatalog.CreateDefaultLaunchCatalog();
            Require(levels.Count == BUXLaunchLevelCatalog.LaunchLevelCount, "Launch catalog must contain 120 levels.");
            Require(levels[0].WorldId == "berry_village", "First world must be Berry Village.");
            Require(levels[119].WorldId == "champion_grove", "Final launch world must be Champion Grove.");

            foreach (var level in levels)
            {
                Require(level.Width == 8 && level.Height == 8, "Unexpected launch board size at level " + level.LevelId);
                Require(level.MoveLimit >= 18, "Move limit too low at level " + level.LevelId);
                var board = new BoardEngine(level.Width, level.Height, level.Seed);
                Require(board.HasAnyValidMove(), "Launch level generated no executable move at level " + level.LevelId);
            }

            var rewards = new BUXRewardService();
            rewards.Grant(new BUXRewardGrant { Source = "validation", Coins = 100, Stars = 3, Trophies = 1 });
            Require(rewards.Wallet.Coins == 100 && rewards.Wallet.Stars == 3 && rewards.Wallet.Trophies == 1, "Reward grant failed.");

            var challengeService = new BUXSameBoardChallengeService();
            var a = challengeService.CreateChallenge(12, 99);
            var b = challengeService.CreateChallenge(12, 99);
            Require(a.BoardSeed == b.BoardSeed && a.ChallengeId == b.ChallengeId, "Same-board challenge seed is not deterministic.");
            Require(a.FairMode, "Default challenge must be fair mode.");

            var queue = new BUXCompanionReactionQueue();
            queue.Enqueue(BUXCompanionReaction.SmallHappy);
            queue.Enqueue(BUXCompanionReaction.Victory);
            Require(queue.DequeueOrIdle() == BUXCompanionReaction.SmallHappy, "Companion queue order failed.");
            Require(queue.DequeueOrIdle() == BUXCompanionReaction.Victory, "Companion queue second item failed.");
            Require(queue.DequeueOrIdle() == BUXCompanionReaction.Idle, "Companion queue idle fallback failed.");
        }

        private static void Require(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
