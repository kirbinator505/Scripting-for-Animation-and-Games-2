using System;
using UnityEngine;

public class CollectionBehavior : MonoBehaviour
{
    public CollectableSO collectedObj;
    public CollectionSO collection;

    void start()
    {
        EnableDisableCollectable(!collectedObj.collected);
    }

    private void OnTriggerEnter(Collider other)
    {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value)
    {
        GetComponent<MeshRenderer>().enabled = value;
        GetComponent<Collider>().enabled = value;
    }
}
