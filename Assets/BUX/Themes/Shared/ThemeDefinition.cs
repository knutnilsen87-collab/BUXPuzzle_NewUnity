using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/Theme Definition", fileName = "BUXForest.theme")]
    public sealed class ThemeDefinition : ScriptableObject
    {
        public string ThemeId = "bux_forest";
        public string DisplayName = "BUX Forest";
        public TileSetConfig TileSet;
        public BoardThemeConfig Board;
        public UIThemeConfig UI;
        public AudioThemeConfig Audio;
        public VfxThemeConfig Vfx;
    }
}
