using System.Collections.Generic;
using System.IO;
using BUX.Themes;
using UnityEditor;
using UnityEngine;

namespace BUX.Editor.AssetTools
{
    public static class BUXForestThemeAssetGenerator
    {
        private const string ThemeRoot = "Assets/BUX/Themes/BUXForest";
        private const string CatalogRoot = "Assets/BUX/Data/ThemeCatalog";

        [MenuItem("BUX/Assets/Generate BUX Forest Theme Assets")]
        public static void Generate()
        {
            Directory.CreateDirectory(ThemeRoot);
            Directory.CreateDirectory(CatalogRoot);

            var tileSet = LoadOrCreate<TileSetConfig>($"{ThemeRoot}/TileSet_BUXForest.asset");
            var board = LoadOrCreate<BoardThemeConfig>($"{ThemeRoot}/BoardTheme_BUXForest.asset");
            var ui = LoadOrCreate<UIThemeConfig>($"{ThemeRoot}/UITheme_BUXForest.asset");
            var audio = LoadOrCreate<AudioThemeConfig>($"{ThemeRoot}/AudioTheme_BUXForest.asset");
            var vfx = LoadOrCreate<VfxThemeConfig>($"{ThemeRoot}/VfxTheme_BUXForest.asset");
            var theme = LoadOrCreate<ThemeDefinition>($"{ThemeRoot}/BUXForest.theme.asset");
            var catalog = LoadOrCreate<ThemeCatalog>($"{CatalogRoot}/ThemeCatalog.asset");

            FillTileSet(tileSet);
            FillBoard(board);
            FillUI(ui);
            FillAudio(audio);

            theme.ThemeId = "bux_forest";
            theme.DisplayName = "BUX Forest";
            theme.TileSet = tileSet;
            theme.Board = board;
            theme.UI = ui;
            theme.Audio = audio;
            theme.Vfx = vfx;

            catalog.DefaultTheme = theme;
            catalog.Themes.Clear();
            catalog.Themes.Add(theme);

            EditorUtility.SetDirty(tileSet);
            EditorUtility.SetDirty(board);
            EditorUtility.SetDirty(ui);
            EditorUtility.SetDirty(audio);
            EditorUtility.SetDirty(vfx);
            EditorUtility.SetDirty(theme);
            EditorUtility.SetDirty(catalog);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        public static void GenerateAndExit()
        {
            Generate();
            UnityEditor.EditorApplication.Exit(0);
        }

        private static T LoadOrCreate<T>(string path) where T : ScriptableObject
        {
            var asset = AssetDatabase.LoadAssetAtPath<T>(path);
            if (asset != null)
            {
                return asset;
            }

            asset = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(asset, path);
            return asset;
        }

        private static void FillTileSet(TileSetConfig tileSet)
        {
            tileSet.CoreTiles = BindSprites(new Dictionary<string, string>
            {
                { "red_berry", "red_berry_tile.png" },
                { "blueberry", "blueberry_tile.png" },
                { "green_leaf", "green_leaf_tile.png" },
                { "pink_flower", "pink_flower_tile.png" },
                { "white_daisy", "white_daisy_tile.png" },
                { "mushroom", "mushroom_tile.png" },
                { "acorn", "acorn_tile.png" },
                { "bear_head", "bear_head_tile.png" },
                { "bee", "bee_tile.png" }
            });

            tileSet.SpecialTiles = BindSprites(new Dictionary<string, string>
            {
                { "berry_bomb", "berry_bomb_tile.png" },
                { "striped_berry_rocket", "striped_berry_rocket_tile.png" },
                { "special_rocket_horizontal", "special_rocket_horizontal.png" },
                { "special_rocket_vertical", "special_rocket_vertical.png" },
                { "rainbow_blast_orb", "rainbow_blast_orb_tile.png" },
                { "rainbow_flower", "rainbow_flower_tile.png" },
                { "super_berry", "super_berry_booster_tile.png" }
            });

            tileSet.Blockers = BindSprites(new Dictionary<string, string>
            {
                { "moss", "moss_patch_tile.png" },
                { "covered_moss", "covered_moss_tile.png" },
                { "ice_full", "blocker_ice_full.png" },
                { "ice_cracked", "blocker_ice_cracked.png" },
                { "vine_full", "blocker_vine_full.png" },
                { "vine_cut_01", "blocker_vine_cut_01.png" },
                { "pebble_full", "blocker_pebble_full.png" },
                { "pebble_cracked_01", "blocker_pebble_cracked_01.png" },
                { "pebble_cracked_02", "blocker_pebble_cracked_02.png" }
            });

            tileSet.Objectives = BindSprites(new Dictionary<string, string>
            {
                { "basket", "basket_tile.png" },
                { "honey_pot", "honey_pot_tile.png" },
                { "basket_full", "objective_basket_full.png" },
                { "honey_pot_open", "objective_honey_pot_open.png" }
            });

            tileSet.Boosters = BindSprites(new Dictionary<string, string>
            {
                { "shovel", "shovel_booster_tile.png" },
                { "hammer", "booster_hammer_icon.png" },
                { "magic_glove", "booster_magic_glove_icon.png" },
                { "paint_brush", "booster_paint_brush_icon.png" }
            });
        }

        private static void FillBoard(BoardThemeConfig board)
        {
            board.GameplayBackground = FindSprite("level_background_berry_village.png");
            board.BoardFrame = FindSprite("wooden_board_frame.png");
            board.BoardSurface = FindSprite("board_inner_grid_surface.png");
            board.CellSlot = FindSprite("board_cell_brown.png");
            board.EmptyArea = FindSprite("board_empty_area.png");
            board.WorldBackgrounds = BindSprites(new Dictionary<string, string>
            {
                { "berry_village", "map_board_world_01_berry_village.png" },
                { "mossy_forest", "map_board_world_02_mossy_forest.png" },
                { "honey_hills", "map_board_world_03_honey_hills.png" },
                { "magic_clearing", "map_board_world_04_magic_clearing.png" },
                { "moonlit_grove", "map_board_world_05_moonlit_grove.png" },
                { "crystal_garden", "map_board_world_06_crystal_garden.png" }
            });
            board.BoardSkins = BindSprites(new Dictionary<string, string>
            {
                { "challenge", "challenge_board_skins_atlas.png" },
                { "event", "event_board_skins_atlas.png" }
            });
        }

        private static void FillUI(UIThemeConfig ui)
        {
            ui.HudGoalPanel = FindSprite("goal_panel.png");
            ui.HudLevelPanel = FindSprite("level_panel.png");
            ui.HudMovesPanel = FindSprite("moves_left_panel.png");
            ui.HudScorePanel = FindSprite("score_panel.png");
            ui.BoosterBarPanel = FindSprite("ui_booster_bar_panel.png");
            ui.PrimaryButton = FindSprite("ui_button_primary.png");
            ui.SecondaryButton = FindSprite("ui_button_secondary.png");
            ui.DisabledButton = FindSprite("ui_button_disabled.png");
            ui.CloseButton = FindSprite("ui_button_close.png");
            ui.LevelStartPopup = FindSprite("ui_level_start_popup.png");
            ui.LevelCompletePopup = FindSprite("ui_level_complete_popup.png");
            ui.LevelFailedPopup = FindSprite("ui_level_failed_popup.png");
            ui.RewardPopup = FindSprite("ui_reward_popup.png");
            ui.Icons = BindSprites(new Dictionary<string, string>
            {
                { "coin", "icon_coin.png" },
                { "star", "icon_star.png" },
                { "trophy", "icon_trophy.png" },
                { "honey_token", "icon_honey_token.png" },
                { "cosmetic_shard", "icon_cosmetic_shard.png" },
                { "booster_fragment", "icon_booster_fragment.png" },
                { "key", "icon_key.png" },
                { "heart_life", "icon_heart_life.png" }
            });
        }

        private static void FillAudio(AudioThemeConfig audio)
        {
            audio.MainMenuMusic = FindAudio("06_main_menu_music.mp3");
            audio.GameplayCalmMusic = FindAudio("07_gameplay_calm_music.mp3");
            audio.LevelMapMusic = FindAudio("10_level_map_music.mp3");
            audio.ForestAmbience = FindAudio("34_forest_ambience_duplicate.mp3") ?? FindAudio("01_forest_day_ambience.mp3");
            audio.Sfx = BindAudio(new Dictionary<string, string>
            {
                { "tile_select", "Tile Select" },
                { "tile_swap", "Tile Swap" },
                { "invalid_swap", "Invalid Tile Swap" },
                { "board_shuffle", "Board Shuffle" },
                { "board_hint", "Board Hint" },
                { "level_start", "17_level_start.mp3" },
                { "level_win", "15_level_win.mp3" },
                { "level_failed", "16_level_failed.mp3" },
                { "objective_complete", "18_objective_complete.mp3" },
                { "match_4_special_created", "20_match_4_special_created.mp3" },
                { "match_5_special_created", "21_match_5_special_created.mp3" }
            });
        }

        private static List<SpriteBinding> BindSprites(Dictionary<string, string> map)
        {
            var result = new List<SpriteBinding>();
            foreach (var pair in map)
            {
                result.Add(new SpriteBinding { Id = pair.Key, Sprite = FindSprite(pair.Value) });
            }
            return result;
        }

        private static List<AudioBinding> BindAudio(Dictionary<string, string> map)
        {
            var result = new List<AudioBinding>();
            foreach (var pair in map)
            {
                result.Add(new AudioBinding { Id = pair.Key, Clip = FindAudio(pair.Value) });
            }
            return result;
        }

        private static Sprite FindSprite(string fileName)
        {
            var path = FindAssetPath(fileName);
            return string.IsNullOrEmpty(path) ? null : AssetDatabase.LoadAssetAtPath<Sprite>(path);
        }

        private static AudioClip FindAudio(string fileNameOrPrefix)
        {
            var path = FindAssetPath(fileNameOrPrefix);
            return string.IsNullOrEmpty(path) ? null : AssetDatabase.LoadAssetAtPath<AudioClip>(path);
        }

        private static string FindAssetPath(string fileNameOrPrefix)
        {
            var normalized = fileNameOrPrefix.ToLowerInvariant();
            foreach (var guid in AssetDatabase.FindAssets(Path.GetFileNameWithoutExtension(fileNameOrPrefix), new[] { "Assets/BUX" }))
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                if (path.Contains("/_Review/"))
                {
                    continue;
                }

                var name = Path.GetFileName(path).ToLowerInvariant();
                if (name == normalized || name.StartsWith(normalized))
                {
                    return path;
                }
            }

            return null;
        }
    }
}
