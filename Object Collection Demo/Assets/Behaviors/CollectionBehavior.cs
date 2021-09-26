using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionBehavior : MonoBehaviour
{
    public CollectableSO collectedObj;
    public CollectionSO collection;

    private void OnTriggerEnter(Collider other)
    {
        collection.Collect(collectedObj);
        EnableDisable(false);
    }

    private void EnableDisable(bool value)
    {
        GetComponent<MeshRenderer>().enabled = value;
        GetComponent<Collider>().enabled = value;
    }
}
