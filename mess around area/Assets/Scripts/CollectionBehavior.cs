using System;
using UnityEngine;

public class CollectionBehavior : MonoBehaviour
{
    private GameObject art;
    private SpriteRenderer artSpriteRenderer;
    public CollectableSO collectedObj;
    public CollectionSO collection;

    private void Awake()
    {
        ConfigCollectable();
    }

    public void SwapCollectable(CollectableSO collectable)
    {
        collectedObj = collectable;
        ConfigCollectable();
    }

    private void ConfigCollectable()
    {
        art = GetComponentInChildren<Transform>().gameObject;
        artSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        if (artSpriteRenderer != null)
        {
            artSpriteRenderer.sprite = collectedObj.art2d;
            artSpriteRenderer.color = collectedObj.artColorTint;
        }
        EnableDisableCollectable(!collectedObj.collected);
    }

    void start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value)
    {
        art.SetActive(value);
        GetComponent<MeshRenderer>().enabled = value;
        GetComponent<Collider>().enabled = value;
    }
}
