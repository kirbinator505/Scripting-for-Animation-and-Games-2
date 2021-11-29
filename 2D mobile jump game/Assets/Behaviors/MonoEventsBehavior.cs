using UnityEngine;
using UnityEngine.Events;
public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, destroyEvent, applicationQuitEvent;
    private void Start()
    {
        startEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }

    private void OnApplicationQuit()
    {
        applicationQuitEvent.Invoke();
    }
}
