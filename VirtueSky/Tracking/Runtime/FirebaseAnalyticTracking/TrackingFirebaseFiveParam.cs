using UnityEngine;
using VirtueSky.Inspector;

namespace VirtueSky.Tracking
{
    [CreateAssetMenu(menuName = "Sunflower/Tracking Event/Firebase Analytic/Tracking 5 Param",
        fileName = "tracking_firebase_5_param")]
    [EditorIcon("scriptable_firebase")]
    public class TrackingFirebaseFiveParam : TrackingFirebase
    {
        [Space] [HeaderLine("Parameter Name")] [SerializeField]
        private string parameterName1;

        [SerializeField] private string parameterName2;
        [SerializeField] private string parameterName3;
        [SerializeField] private string parameterName4;
        [SerializeField] private string parameterName5;

        public void TrackEvent(string parameterValue1, string parameterValue2, string parameterValue3,
            string parameterValue4, string parameterValue5)
        {
            if (!Application.isMobilePlatform) return;
#if VIRTUESKY_FIREBASE_ANALYTIC
            Firebase.Analytics.Parameter[] parameters =
            {
                new(parameterName1, parameterValue1), new(parameterName2, parameterValue2),
                new(parameterName3, parameterValue3), new(parameterName4, parameterValue4),
                new(parameterName5, parameterValue5)
            };
            Firebase.Analytics.FirebaseAnalytics.LogEvent(eventName, parameters);
            onTracked?.Invoke();
#endif
        }
    }
}