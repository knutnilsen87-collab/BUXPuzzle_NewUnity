using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/Board Theme Config", fileName = "BoardTheme_BUXForest")]
    public sealed class BoardThemeConfig : ScriptableObject
    {
        public Sprite GameplayBackground;
        public Sprite BoardFrame;
        public Sprite BoardSurface;
        public Sprite CellSlot;
        public Sprite EmptyArea;
        public Sprite SelectionRing;
        public Sprite HintRing;
        public List<SpriteBinding> WorldBackgrounds = new List<SpriteBinding>();
        public List<SpriteBinding> BoardSkins = new List<SpriteBinding>();
    }
}
