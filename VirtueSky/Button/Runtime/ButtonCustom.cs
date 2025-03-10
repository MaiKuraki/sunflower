using PrimeTween;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using VirtueSky.Audio;
using VirtueSky.Inspector;
using VirtueSky.Events;
using VirtueSky.Misc;
using VirtueSky.Utils;
using Button = UnityEngine.UI.Button;

#if UNITY_EDITOR
using VirtueSky.UtilsEditor;
#endif


namespace VirtueSky.UIButton
{
    [EditorIcon("icon_button")]
    public abstract class ButtonCustom : Button
    {
        public ClickButtonEvent clickButtonEvent;

        [HeaderLine("Motion", false, CustomColor.Yellow, CustomColor.Orange)] [SerializeField]
        private bool isMotion = true;

        [SerializeField] private Ease easingTypes = Ease.OutQuint;

        [SerializeField] private float scale = 0.9f;
        [SerializeField] private bool isShrugOver;
        [SerializeField] private float timeShrug = .2f;
        [SerializeField] private float strength = .2f;

        [HeaderLine("Sound Fx Click Button", false, CustomColor.Aqua, CustomColor.Salmon)] [SerializeField]
        private bool useSoundFx;

        [SerializeField] private PlaySfxEvent playSfxEvent;
        [SerializeField] private SoundData soundDataClickButton;

        Vector3 originScale = Vector3.one;
        private bool canShrug = true;
        private Tween _tween;

        protected override void OnEnable()
        {
            base.OnEnable();
            originScale = transform.localScale;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            ResetScale();
        }


        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            DoScale();
            if (useSoundFx)
            {
                soundDataClickButton.PlaySfx(playSfxEvent);
            }

            if (clickButtonEvent != null)
            {
                clickButtonEvent.Raise();
            }
            else
            {
                Debug.Log($"Click button event ({gameObject.name}) null");
            }
        }


        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            ResetScale();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            Shrug();
        }

        void DoScale()
        {
            if (isMotion)
            {
                _tween = Tween.Scale(transform, originScale * scale, .15f, easingTypes);
            }
        }

        void Shrug()
        {
            if (isMotion && isShrugOver && canShrug)
            {
                canShrug = false;
                if (isMotion && isShrugOver)
                {
                    transform.Shrug(timeShrug, strength, Ease.OutQuad, () => { canShrug = true; });
                }
            }
        }

        void ResetScale()
        {
            if (isMotion)
            {
                _tween.Stop();
                transform.localScale = originScale;
            }
        }
#if UNITY_EDITOR
        protected override void Reset()
        {
            base.Reset();
            GetClickButtonEvent();
            playSfxEvent =
                CreateAsset.CreateAndGetScriptableAsset<PlaySfxEvent>("/Audio/Sfx_Event", "play_sfx_event", false);
        }

        public void GetClickButtonEvent()
        {
            clickButtonEvent = CreateAsset.CreateAndGetScriptableAsset<ClickButtonEvent>("/Event");
            EditorUtility.SetDirty(this);
        }
#endif
    }
}