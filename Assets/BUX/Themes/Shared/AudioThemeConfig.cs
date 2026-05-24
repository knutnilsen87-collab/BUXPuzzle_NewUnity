using System;
using System.Collections.Generic;
using UnityEngine;

namespace BUX.Themes
{
    [CreateAssetMenu(menuName = "BUX/Themes/Audio Theme Config", fileName = "AudioTheme_BUXForest")]
    public sealed class AudioThemeConfig : ScriptableObject
    {
        public AudioClip MainMenuMusic;
        public AudioClip GameplayCalmMusic;
        public AudioClip LevelMapMusic;
        public AudioClip ForestAmbience;
        public List<AudioBinding> Sfx = new List<AudioBinding>();
    }

    [Serializable]
    public sealed class AudioBinding
    {
        public string Id;
        public AudioClip Clip;
    }
}
