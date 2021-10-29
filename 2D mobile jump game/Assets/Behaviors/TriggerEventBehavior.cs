using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEnterEvent.Invoke();
    }
}
