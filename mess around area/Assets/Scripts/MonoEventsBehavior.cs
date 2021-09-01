using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, destroyEvent;

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}

