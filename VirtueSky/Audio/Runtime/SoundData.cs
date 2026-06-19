using System.Collections.Generic;
using UnityEngine;
using VirtueSky.Inspector;
using VirtueSky.Core;
using VirtueSky.Misc;

namespace VirtueSky.Audio
{
    [CreateAssetMenu(menuName = "Sunflower/Audio/Sound Data", fileName = "sound_data")]
    [EditorIcon("scriptable_audioclip")]
    public class SoundData : BaseSO
    {
        public enum GetType
        {
            Random,
            Sequence,
            Index
        }

        [Space] public bool loop = false;
        [Range(0f, 1f)] public float volume = 1;
        public SoundType soundType;
        [Space, Header("Fade Volume - Only Music"), Tooltip("Only Music Background")] [ShowIf(nameof(soundType), SoundType.Music)]
        public bool isMusicFadeVolume = false;

        [ShowIf(nameof(ConditionFadeMusic), true)]
        public float fadeInDuration = .5f;

        [ShowIf(nameof(ConditionFadeMusic), true)]
        public float fadeOutDuration = .5f;

        [Space] public GetType getType = GetType.Random;
        [Tooltip("Use Index Clip for GetType Index"), SerializeField]
        private int indexClip = 0;

        [SerializeField] private List<AudioClip> audioClips = new List<AudioClip>();
        public bool ConditionFadeMusic => isMusicFadeVolume && soundType == SoundType.Music;
        private int sequenceIndex = 0;
        public int NumberOfAudioClips => audioClips?.Count ?? 0;
        public List<AudioClip> AudioClips() => audioClips ?? new List<AudioClip>();

        public AudioClip GetAudioClip(int index = -1)
        {
            if (audioClips.Count > 0)
            {
                switch (getType)
                {
                    case GetType.Random:
                        return audioClips[Random.Range(0, audioClips.Count)];
                    case GetType.Sequence:
                        var clip = audioClips[sequenceIndex];
                        if (sequenceIndex < audioClips.Count - 1)
                        {
                            sequenceIndex++;
                        }
                        else
                        {
                            sequenceIndex = 0;
                        }

                        return clip;
                    case GetType.Index:
                        if (index >= 0)
                        {
                            indexClip = index;
                        }

                        indexClip = Mathf.Clamp(indexClip, 0, audioClips.Count - 1);
                        return audioClips[indexClip];
                }
            }

            return null;
        }

        public void AddAudioClip(AudioClip audioClip)
        {
            audioClips.Add(audioClip);
        }

        public void AddAudioClips(List<AudioClip> clips)
        {
            audioClips.Adds(clips);
        }

        public void AddAudioClips(AudioClip[] clips)
        {
            audioClips.Adds(clips);
        }

        public void ClearAudioClips()
        {
            if (audioClips.IsNullOrEmpty()) return;
            audioClips.Clear();
        }
    }
    public enum SoundType
    {
        Sfx,
        Music
    }
}