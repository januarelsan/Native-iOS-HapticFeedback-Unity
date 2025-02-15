using Quasi.HapticFeedback;
using UnityEngine;
using UnityEngine.UI;

public class HapticFeedbackExample : MonoBehaviour
{
    [SerializeField] private Button light, medium, heavy, rigid, soft, success, warning, error, selection;

    private void Awake()
    {
        light.onClick.AddListener(Light);
        medium.onClick.AddListener(Medium);
        heavy.onClick.AddListener(Heavy);
        rigid.onClick.AddListener(Rigid);
        soft.onClick.AddListener(Soft);
        
        success.onClick.AddListener(Success);
        warning.onClick.AddListener(Warning);
        error.onClick.AddListener(Error);
        
        selection.onClick.AddListener(Selection);
    }

    private void Light()
    {
        HapticFeedback.TriggerImpactHaptic(0);
    }
    
    private void Medium()
    {
        HapticFeedback.TriggerImpactHaptic(1);
    }
    
    private void Heavy()
    {
        HapticFeedback.TriggerImpactHaptic(2);
    }

    private void Rigid()
    {
        HapticFeedback.TriggerImpactHaptic(3);
    }

    private void Soft()
    {
        HapticFeedback.TriggerImpactHaptic(4);
    }
    
    private void Success()
    {
        HapticFeedback.TriggerNotificationHaptic(0);
    }
    
    private void Warning()
    {
        HapticFeedback.TriggerNotificationHaptic(1);
    }
    
    private void Error()
    {
        HapticFeedback.TriggerNotificationHaptic(2);
    }

    private void Selection()
    {
        HapticFeedback.TriggerSelectionHaptic();
    }
}
