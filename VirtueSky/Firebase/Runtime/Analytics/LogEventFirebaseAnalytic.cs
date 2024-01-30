using System;
#if VIRTUESKY_FIREBASE_ANALYTIC
using Firebase.Analytics;
#endif
using UnityEngine;

namespace VirtueSky.Firebase
{
    [CreateAssetMenu(menuName = "Firebase Analytic/Log Event",
        fileName = "log_event_firebase_analytic")]
    public class LogEventFirebaseAnalytic : ScriptableObject
    {
        public void Init()
        {
#if VIRTUESKY_FIREBASE_ANALYTIC
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
#endif
        }

        public void LogEvent(string eventName)
        {
            if (!Application.isMobilePlatform)
            {
                return;
            }
#if VIRTUESKY_FIREBASE_ANALYTIC
            try
            {
                FirebaseAnalytics.LogEvent(eventName);
            }
            catch (Exception e)
            {
                Debug.LogError("Event log error: " + e.ToString());
                throw;
            }
#endif
        }

        public void LogEvent(string eventName, string parameterName, string parameterValue)
        {
            if (!Application.isMobilePlatform)
            {
                return;
            }
#if VIRTUESKY_FIREBASE_ANALYTIC
            try
            {
                Parameter[] parameters =
                {
                    new Parameter(parameterName, parameterValue)
                };
                FirebaseAnalytics.LogEvent(eventName, parameters);
            }
            catch (Exception e)
            {
                Debug.LogError("Event log error: " + e.ToString());
                throw;
            }
#endif
        }

#if VIRTUESKY_FIREBASE_ANALYTIC
        public void LogEvent(string eventName, Parameter[] parameters)
        {
            if (!Application.isMobilePlatform)
            {
                return;
            }

            try
            {
                FirebaseAnalytics.LogEvent(eventName, parameters);
            }
            catch (Exception e)
            {
                Debug.LogError("Event log error: " + e.ToString());
                throw;
            }
        }
#endif
    }
}