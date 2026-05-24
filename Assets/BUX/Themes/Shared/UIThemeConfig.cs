using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/UI Theme Config", fileName = "UITheme_BUXForest")]
    public sealed class UIThemeConfig : ScriptableObject
    {
        public Font DisplayFont;
        public Font BodyFont;

        public Color Primary = new Color(0.18f, 0.45f, 0.24f);
        public Color PrimaryDark = new Color(0.08f, 0.24f, 0.13f);
        public Color Accent = new Color(0.95f, 0.69f, 0.22f);
        public Color CardBackground = new Color(0.98f, 0.94f, 0.83f);
        public Color TextDark = new Color(0.12f, 0.09f, 0.05f);
        public Color TextLight = Color.white;

        public Sprite HudGoalPanel;
        public Sprite HudLevelPanel;
        public Sprite HudMovesPanel;
        public Sprite HudScorePanel;
        public Sprite BoosterBarPanel;
        public Sprite PrimaryButton;
        public Sprite SecondaryButton;
        public Sprite DisabledButton;
        public Sprite CloseButton;
        public Sprite LevelStartPopup;
        public Sprite LevelCompletePopup;
        public Sprite LevelFailedPopup;
        public Sprite RewardPopup;
        public List<SpriteBinding> Icons = new List<SpriteBinding>();
    }
}
