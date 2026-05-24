using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/Theme Catalog", fileName = "ThemeCatalog")]
    public sealed class ThemeCatalog : ScriptableObject
    {
        public ThemeDefinition DefaultTheme;
        public List<ThemeDefinition> Themes = new List<ThemeDefinition>();
    }
}
