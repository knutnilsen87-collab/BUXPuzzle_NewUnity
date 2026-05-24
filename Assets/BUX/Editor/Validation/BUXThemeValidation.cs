using System.Collections.Generic;
using System.IO;
using BUX.Themes;
using UnityEditor;
using UnityEngine;

namespace BUX.Editor.Validation
{
    public static class BUXThemeValidation
    {
        private const string ReportPath = "theme_validation_report.txt";
        private const string CatalogPath = "Assets/BUX/Data/ThemeCatalog/ThemeCatalog.asset";

        [MenuItem("BUX/Validation/Run Theme Validation")]
        public static void RunThemeValidation()
        {
            var failures = new List<string>();
            var warnings = new List<string>();
            Validate(failures, warnings);
            WriteReport(failures, warnings);

            if (failures.Count > 0)
            {
                Debug.LogError($"BUX theme validation failed with {failures.Count} failure(s). See {ReportPath}.");
                return;
            }

            Debug.Log($"BUX theme validation passed with {warnings.Count} warning(s). See {ReportPath}.");
        }

        public static void RunThemeValidationAndExit()
        {
            var failures = new List<string>();
            var warnings = new List<string>();
            Validate(failures, warnings);
            WriteReport(failures, warnings);
            UnityEditor.EditorApplication.Exit(failures.Count == 0 ? 0 : 1);
        }

        private static void Validate(List<string> failures, List<string> warnings)
        {
            var catalog = AssetDatabase.LoadAssetAtPath<ThemeCatalog>(CatalogPath);
            if (catalog == null)
            {
                failures.Add($"Missing ThemeCatalog at {CatalogPath}.");
                return;
            }

            if (catalog.DefaultTheme == null)
            {
                failures.Add("ThemeCatalog.DefaultTheme is not assigned.");
                return;
            }

            var theme = catalog.DefaultTheme;
            Require(theme.ThemeId == "bux_forest", failures, "Default theme id must be bux_forest.");
            Require(theme.TileSet != null, failures, "Default theme TileSet is missing.");
            Require(theme.Board != null, failures, "Default theme Board config is missing.");
            Require(theme.UI != null, failures, "Default theme UI config is missing.");
            Require(theme.Audio != null, failures, "Default theme Audio config is missing.");
            Require(theme.Vfx != null, failures, "Default theme VFX config is missing.");
            CheckNoReviewReference(theme, failures, "ThemeDefinition");

            if (theme.TileSet != null)
            {
                RequireSprites(theme.TileSet.CoreTiles, failures, "core tile");
                RequireSprites(theme.TileSet.Blockers, failures, "blocker");
                RequireSprites(theme.TileSet.SpecialTiles, warnings, "special tile");
                RequireSprites(theme.TileSet.Objectives, warnings, "objective");
                RequireSprites(theme.TileSet.Boosters, warnings, "booster");
                CheckNoReviewReference(theme.TileSet, failures, "TileSetConfig");
            }

            if (theme.Board != null)
            {
                Require(theme.Board.GameplayBackground != null, failures, "Board gameplay background is missing.");
                Require(theme.Board.BoardFrame != null, warnings, "Board frame sprite is missing.");
                Require(theme.Board.BoardSurface != null, warnings, "Board surface sprite is missing.");
                Require(theme.Board.CellSlot != null, failures, "Board cell slot sprite is missing.");
                CheckNoReviewReference(theme.Board, failures, "BoardThemeConfig");
            }

            if (theme.UI != null)
            {
                Require(theme.UI.HudGoalPanel != null, warnings, "HUD goal panel sprite is missing.");
                Require(theme.UI.HudLevelPanel != null, warnings, "HUD level panel sprite is missing.");
                Require(theme.UI.HudMovesPanel != null, warnings, "HUD moves panel sprite is missing.");
                Require(theme.UI.HudScorePanel != null, warnings, "HUD score panel sprite is missing.");
                Require(theme.UI.LevelCompletePopup != null, warnings, "Level complete popup sprite is missing.");
                Require(theme.UI.PrimaryButton != null, warnings, "Primary button sprite is missing.");
                CheckNoReviewReference(theme.UI, failures, "UIThemeConfig");
            }

            if (theme.Audio != null)
            {
                Require(theme.Audio.GameplayCalmMusic != null, warnings, "Gameplay calm music is missing.");
                Require(theme.Audio.ForestAmbience != null, warnings, "Forest ambience is missing.");
                RequireAudio(theme.Audio.Sfx, warnings);
                CheckNoReviewReference(theme.Audio, failures, "AudioThemeConfig");
            }
        }

        private static void Require(bool condition, List<string> bucket, string message)
        {
            if (!condition)
            {
                bucket.Add(message);
            }
        }

        private static void RequireSprites(IEnumerable<SpriteBinding> bindings, List<string> bucket, string label)
        {
            foreach (var binding in bindings)
            {
                if (binding == null || binding.Sprite == null)
                {
                    bucket.Add($"Missing {label} sprite for id '{binding?.Id ?? "<null>"}'.");
                }
            }
        }

        private static void RequireAudio(IEnumerable<AudioBinding> bindings, List<string> bucket)
        {
            foreach (var binding in bindings)
            {
                if (binding == null || binding.Clip == null)
                {
                    bucket.Add($"Missing audio clip for id '{binding?.Id ?? "<null>"}'.");
                }
            }
        }

        private static void CheckNoReviewReference(Object asset, List<string> failures, string label)
        {
            var serialized = new SerializedObject(asset);
            var property = serialized.GetIterator();
            while (property.NextVisible(true))
            {
                if (property.propertyType != SerializedPropertyType.ObjectReference || property.objectReferenceValue == null)
                {
                    continue;
                }

                var path = AssetDatabase.GetAssetPath(property.objectReferenceValue);
                if (path.Contains("/_Review/"))
                {
                    failures.Add($"{label} references quarantined _Review asset: {path}");
                }
            }
        }

        private static void WriteReport(List<string> failures, List<string> warnings)
        {
            var lines = new List<string>
            {
                "# theme_validation_report",
                "",
                $"- status: {(failures.Count == 0 ? "pass" : "fail")}",
                $"- generated_at: {System.DateTime.Now:yyyy-MM-dd HH:mm:ss}",
                $"- catalog: {CatalogPath}",
                $"- failures: {failures.Count}",
                $"- warnings: {warnings.Count}",
                "",
                "## Failures"
            };
            lines.AddRange(failures.Count == 0 ? new[] { "- None" } : failures.ConvertAll(item => "- " + item));
            lines.Add("");
            lines.Add("## Warnings");
            lines.AddRange(warnings.Count == 0 ? new[] { "- None" } : warnings.ConvertAll(item => "- " + item));
            File.WriteAllLines(ReportPath, lines);
            AssetDatabase.Refresh();
        }
    }
}
