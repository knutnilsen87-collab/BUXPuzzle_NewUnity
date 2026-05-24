using System;
using System.IO;
using BUX.Runtime.Core;
using UnityEditor;
using UnityEngine;

namespace BUX.Editor.Validation
{
    public static class BUXCoreGameplayValidation
    {
        private const string ReportPath = "bux_core_gameplay_validation_report.txt";

        [MenuItem("BUX/Validation/Run Core Gameplay Validation")]
        public static void Run()
        {
            Validate();
            Debug.Log("BUX core gameplay validation passed.");
        }

        public static void RunAndExit()
        {
            try
            {
                Validate();
                File.WriteAllText(ReportPath, "# bux_core_gameplay_validation_report\n\n- status: pass\n- generated_at: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                UnityEditor.EditorApplication.Exit(0);
            }
            catch (Exception ex)
            {
                File.WriteAllText(ReportPath, "# bux_core_gameplay_validation_report\n\n- status: fail\n- generated_at: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n- error: " + ex + "\n");
                Debug.LogException(ex);
                UnityEditor.EditorApplication.Exit(1);
            }
        }

        private static void Validate()
        {
            for (var seed = 1; seed <= 200; seed++)
            {
                var board = new BoardEngine(8, 8, seed * 7919);
                Require(board.HasAnyValidMove(), "Generated board has no executable move for seed " + seed);
                Require(board.ValidMoveCount() > 0, "ValidMoveCount failed for seed " + seed);
            }

            var blocked = new BoardEngine(8, 8, 42);
            var protectedCoord = FindAnyExecutableSwap(blocked, out var other);
            blocked.SetBlocker(protectedCoord, BlockerKind.Vine, 1);
            Require(!blocked.CanPlayerSwap(protectedCoord, other), "Blocked tile was counted as executable.");
            var trace = blocked.TrySwapAndResolve(protectedCoord, other);
            Require(!trace.Accepted && trace.RejectReason == "blocked_or_non_swappable", "Blocked swap did not reject with blocked-specific reason.");

            var playable = new BoardEngine(8, 8, 12345);
            var a = FindAnyExecutableSwap(playable, out var b);
            var accepted = playable.TrySwapAndResolve(a, b);
            Require(accepted.Accepted, "Known executable swap was rejected.");
            Require(playable.HasAnyValidMove(), "Board lost executable moves after resolve/recovery.");
        }

        private static BoardCoord FindAnyExecutableSwap(BoardEngine board, out BoardCoord other)
        {
            for (var y = 0; y < board.Height; y++)
            {
                for (var x = 0; x < board.Width; x++)
                {
                    var a = new BoardCoord(x, y);
                    var right = new BoardCoord(x + 1, y);
                    if (board.CanPlayerSwap(a, right))
                    {
                        other = right;
                        return a;
                    }

                    var up = new BoardCoord(x, y + 1);
                    if (board.CanPlayerSwap(a, up))
                    {
                        other = up;
                        return a;
                    }
                }
            }

            throw new InvalidOperationException("No executable swap found on validation board.");
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
