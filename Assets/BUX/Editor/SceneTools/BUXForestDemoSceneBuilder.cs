using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace BUX.Editor.SceneTools
{
    public static class BUXForestDemoSceneBuilder
    {
        private const string ScenePath = "Assets/BUX/Scenes/BUXForestDemo.unity";

        [MenuItem("BUX/Scenes/Build BUX Forest Demo Scene")]
        public static void BuildScene()
        {
            Directory.CreateDirectory("Assets/BUX/Scenes");

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

            var cameraObject = new GameObject("Main Camera");
            var camera = cameraObject.AddComponent<Camera>();
            cameraObject.tag = "MainCamera";
            cameraObject.transform.position = new Vector3(0f, 0f, -10f);
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = new Color(0.55f, 0.76f, 0.95f);
            camera.orthographic = true;
            camera.orthographicSize = 6.2f;

            var lightObject = new GameObject("Directional Light");
            lightObject.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
            lightObject.AddComponent<Light>().type = LightType.Directional;

            AddSprite("Background", "Assets/BUX/Art/Backgrounds/Gameplay/main_forest_background.png", new Vector3(0f, 0f, 3f), 15f, 11f, 0);
            AddSprite("BUX Puzzle Logo", "Assets/BUX/Art/UI/HUD/bux_puzzle_logo.png", new Vector3(0f, 5.05f, 0f), 3.4f, 1.15f, 20);

            AddSprite("Moves Panel", "Assets/BUX/Art/UI/HUD/moves_left_panel.png", new Vector3(-4.6f, 4.2f, 0f), 2.05f, 0.85f, 18);
            AddWorldText("Moves Text", "MOVES 24", new Vector3(-4.6f, 4.18f, -0.02f), 0.34f, Color.white, 25);

            AddSprite("Score Panel", "Assets/BUX/Art/UI/HUD/score_panel.png", new Vector3(4.6f, 4.2f, 0f), 2.05f, 0.85f, 18);
            AddWorldText("Score Text", "SCORE 12 450", new Vector3(4.6f, 4.18f, -0.02f), 0.3f, Color.white, 25);

            AddSprite("Goal Panel", "Assets/BUX/Art/UI/HUD/goal_panel.png", new Vector3(0f, 4.2f, 0f), 2.45f, 0.85f, 18);
            AddWorldText("Goal Text", "COLLECT", new Vector3(-0.35f, 4.18f, -0.02f), 0.28f, Color.white, 25);
            AddSprite("Goal Icon Red Berry", "Assets/BUX/Art/UI/Icons/Goals/goal_icon_red_berry.png", new Vector3(0.75f, 4.18f, -0.03f), 0.45f, 0.45f, 26);

            AddSprite("Wooden Board Frame", "Assets/BUX/Art/Board/Frames/wooden_board_frame.png", new Vector3(0f, -0.35f, 0f), 6.4f, 6.4f, 5);
            BuildBoard();

            AddSprite("Companion Bear", "Assets/BUX/Art/Companion/Bear/GameplayPoses/companion_bear_happy.png", new Vector3(5.15f, -2.6f, 0f), 2.0f, 2.0f, 28);
            AddSprite("Play Button", "Assets/BUX/Art/UI/Buttons/ui_button_play.png", new Vector3(4.6f, -4.65f, 0f), 2.0f, 0.95f, 24);
            AddWorldText("Theme Pack Label", "BUXForest theme pack", new Vector3(0f, -5.45f, -0.02f), 0.3f, new Color(0.18f, 0.23f, 0.18f), 30);

            EditorSceneManager.SaveScene(scene, ScenePath);
            EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(ScenePath, true) };
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log("BUX Forest demo scene built at " + ScenePath);
        }

        public static void BuildSceneAndExit()
        {
            try
            {
                BuildScene();
                EditorApplication.Exit(0);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                EditorApplication.Exit(1);
            }
        }

        private static void BuildBoard()
        {
            var tilePaths = new[]
            {
                "Assets/BUX/Art/Tiles/Core/red_berry_tile.png",
                "Assets/BUX/Art/Tiles/Core/blueberry_tile.png",
                "Assets/BUX/Art/Tiles/Core/green_leaf_tile.png",
                "Assets/BUX/Art/Tiles/Core/pink_flower_tile.png",
                "Assets/BUX/Art/Tiles/Core/white_daisy_tile.png",
                "Assets/BUX/Art/Tiles/Core/mushroom_tile.png",
                "Assets/BUX/Art/Tiles/Core/acorn_tile.png",
                "Assets/BUX/Art/Tiles/Core/bear_head_tile.png",
            };

            const int size = 7;
            const float spacing = 0.78f;
            const float originX = -2.34f;
            const float originY = 1.95f;

            for (var y = 0; y < size; y++)
            {
                for (var x = 0; x < size; x++)
                {
                    var position = new Vector3(originX + x * spacing, originY - y * spacing, 0f);
                    AddSprite($"Cell {x},{y}", "Assets/BUX/Art/Board/Cells/board_cell_brown.png", position, 0.72f, 0.72f, 10);
                    AddSprite($"Tile {x},{y}", tilePaths[(x + y * 3) % tilePaths.Length], position + new Vector3(0f, 0f, -0.03f), 0.58f, 0.58f, 15);
                }
            }
        }

        private static GameObject AddSprite(string name, string path, Vector3 position, float desiredWidth, float desiredHeight, int sortingOrder)
        {
            var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(path);
            if (sprite == null)
            {
                throw new FileNotFoundException("Missing sprite asset for demo scene", path);
            }

            var gameObject = new GameObject(name);
            gameObject.transform.position = position;
            var renderer = gameObject.AddComponent<SpriteRenderer>();
            renderer.sprite = sprite;
            renderer.sortingOrder = sortingOrder;

            var bounds = sprite.bounds.size;
            gameObject.transform.localScale = new Vector3(desiredWidth / bounds.x, desiredHeight / bounds.y, 1f);
            return gameObject;
        }

        private static void AddWorldText(string name, string text, Vector3 position, float size, Color color, int sortingOrder)
        {
            var gameObject = new GameObject(name);
            gameObject.transform.position = position;
            var mesh = gameObject.AddComponent<TextMesh>();
            mesh.text = text;
            mesh.anchor = TextAnchor.MiddleCenter;
            mesh.alignment = TextAlignment.Center;
            mesh.fontSize = 48;
            mesh.characterSize = size;
            mesh.color = color;

            var renderer = gameObject.GetComponent<MeshRenderer>();
            renderer.sortingOrder = sortingOrder;
        }
    }
}
