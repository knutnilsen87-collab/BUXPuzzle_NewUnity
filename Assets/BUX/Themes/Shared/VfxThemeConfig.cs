using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/VFX Theme Config", fileName = "VfxTheme_BUXForest")]
    public sealed class VfxThemeConfig : ScriptableObject
    {
        public List<GameObjectBinding> Prefabs = new List<GameObjectBinding>();
    }

    [System.Serializable]
    public sealed class GameObjectBinding
    {
        public string Id;
        public GameObject Prefab;
    }
}
