using UnityEngine;
using UnityEngine.Events;
public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent;
    private void Start()
    {
        startEvent.Invoke();
    }
}
