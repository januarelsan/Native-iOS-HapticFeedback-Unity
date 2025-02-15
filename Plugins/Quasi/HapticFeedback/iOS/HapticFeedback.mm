#import <UIKit/UIKit.h>

extern "C"
{
    void triggerImpactHaptic(int intensity)
    {
        UIImpactFeedbackStyle style;
                
        switch (intensity) {
            case 0:
                style = UIImpactFeedbackStyleLight;
                break;
            case 1:
                style = UIImpactFeedbackStyleMedium;
                break;
            case 2:
                style = UIImpactFeedbackStyleHeavy;
                break;
            case 3:
                style = UIImpactFeedbackStyleRigid;
                break;
            case 4:
                style = UIImpactFeedbackStyleSoft;
                break;
            default:
                style = UIImpactFeedbackStyleLight;
                break;
        }
        
        UIImpactFeedbackGenerator *feedbackGenerator = [[UIImpactFeedbackGenerator alloc] initWithStyle:style];
        [feedbackGenerator prepare];
        [feedbackGenerator impactOccurred];
    }

    void triggerNotificationHaptic(int type)
    {
        UINotificationFeedbackType feedbackType;
        
        switch (type) {
            case 0:
                feedbackType = UINotificationFeedbackTypeSuccess;
                break;
            case 1:
                feedbackType = UINotificationFeedbackTypeWarning;
                break;
            case 2:
                feedbackType = UINotificationFeedbackTypeError;
                break;
            default:
                feedbackType = UINotificationFeedbackTypeWarning;
                break;
        }
        
        UINotificationFeedbackGenerator *feedbackGenerator = [[UINotificationFeedbackGenerator alloc] init];
        [feedbackGenerator prepare];
        [feedbackGenerator notificationOccurred:feedbackType];
    }

    void triggerSelectionHaptic()
    {
        UISelectionFeedbackGenerator *feedbackGenerator = [[UISelectionFeedbackGenerator alloc] init];
        [feedbackGenerator prepare];
        [feedbackGenerator selectionChanged];
    }
}