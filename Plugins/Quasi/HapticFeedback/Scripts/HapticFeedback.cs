using System.Runtime.InteropServices;

namespace Quasi.HapticFeedback
{
    public class HapticFeedback 
    {
#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void triggerImpactHaptic(int intensity);
        
        [DllImport("__Internal")]
        private static extern void triggerNotificationHaptic(int type);

        [DllImport("__Internal")]
        private static extern void triggerSelectionHaptic();
#endif
    
        /// <summary>
        /// Triggers haptic feedback with the specified intensity.
        /// </summary>
        /// <param name="intensity">The intensity of the haptic feedback.
        /// Use 0 for light, 1 for medium, 2 for heavy, 3 for rigid, 4 for soft</param>
        public static void TriggerImpactHaptic(int intensity)
        {
#if UNITY_IOS && !UNITY_EDITOR
                triggerImpactHaptic(intensity);
#endif
        }
    
        /// <summary>
        /// Triggers notification haptic feedback.
        /// </summary>
        /// <param name="type">The type of the notification haptic feedback.
        /// Use 0 for success, 1 for warning, and 2 for error</param>
        public static void TriggerNotificationHaptic(int type)
        {
#if UNITY_IOS && !UNITY_EDITOR
            triggerNotificationHaptic(type);
#endif
        }
        
        /// <summary>
        /// Triggers selection haptic feedback.
        /// </summary>
        public static void TriggerSelectionHaptic()
        {
#if UNITY_IOS && !UNITY_EDITOR
            triggerSelectionHaptic();
#endif
        }
    }
}
