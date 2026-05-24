using System.IO;
using UnityEditor;
using UnityEngine;

namespace BUX.Editor.Import
{
    public static class BUXAssetImportSettingsApplier
    {
        [MenuItem("BUX/Assets/Apply BUX Import Settings")]
        public static void Apply()
        {
            var changed = 0;
            foreach (var guid in AssetDatabase.FindAssets("t:Texture2D", new[] { "Assets/BUX/Art" }))
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                if (!path.EndsWith(".png", System.StringComparison.OrdinalIgnoreCase) || path.Contains("/_Review/"))
                {
                    continue;
                }

                if (AssetImporter.GetAtPath(path) is not TextureImporter importer)
                {
                    continue;
                }

                var expectedMode = Path.GetFileNameWithoutExtension(path).ToLowerInvariant().Contains("atlas")
                    ? SpriteImportMode.Multiple
                    : SpriteImportMode.Single;

                var dirty = false;
                if (importer.textureType != TextureImporterType.Sprite)
                {
                    importer.textureType = TextureImporterType.Sprite;
                    dirty = true;
                }

                if (importer.spriteImportMode != expectedMode)
                {
                    importer.spriteImportMode = expectedMode;
                    dirty = true;
                }

                if (importer.mipmapEnabled)
                {
                    importer.mipmapEnabled = false;
                    dirty = true;
                }

                if (importer.filterMode != FilterMode.Bilinear)
                {
                    importer.filterMode = FilterMode.Bilinear;
                    dirty = true;
                }

                if (importer.textureCompression != TextureImporterCompression.Compressed)
                {
                    importer.textureCompression = TextureImporterCompression.Compressed;
                    dirty = true;
                }

                if (!dirty)
                {
                    continue;
                }

                importer.SaveAndReimport();
                changed++;
            }

            Debug.Log($"Applied BUX import settings to {changed} texture asset(s).");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        public static void ApplyAndExit()
        {
            Apply();
            UnityEditor.EditorApplication.Exit(0);
        }
    }
}
