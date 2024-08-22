#if VIRTUESKY_ADJUST
using com.adjust.sdk;
#endif
using UnityEngine;
using VirtueSky.Inspector;
using VirtueSky.Utils;

namespace VirtueSky.Tracking
{
    [EditorIcon("icon_scriptable"), HideMonoScript]
    public class AdjustSetting : ScriptableSettings<AdjustSetting>
    {
        [SerializeField] private string appToken;
#if VIRTUESKY_ADJUST
        [SerializeField] private AdjustEnvironment adjustEnvironment = AdjustEnvironment.Production;
        [SerializeField] private AdjustLogLevel logLevel = AdjustLogLevel.Error;
#endif
        public static string AppToken => Instance.appToken;
#if VIRTUESKY_ADJUST
        public static AdjustEnvironment AdjustEnvironment => Instance.adjustEnvironment;
        public static AdjustLogLevel LogLevel => Instance.logLevel;
#endif
    }
}