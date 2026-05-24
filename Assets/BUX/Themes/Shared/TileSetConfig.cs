using System;
using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/Tile Set Config", fileName = "TileSet_BUXForest")]
    public sealed class TileSetConfig : ScriptableObject
    {
        public List<SpriteBinding> CoreTiles = new List<SpriteBinding>();
        public List<SpriteBinding> SpecialTiles = new List<SpriteBinding>();
        public List<SpriteBinding> Blockers = new List<SpriteBinding>();
        public List<SpriteBinding> Objectives = new List<SpriteBinding>();
        public List<SpriteBinding> Boosters = new List<SpriteBinding>();
    }

    [Serializable]
    public sealed class SpriteBinding
    {
        public string Id;
        public Sprite Sprite;
    }
}
