using UnityEngine;

public class CollectionBehavior : MonoBehaviour
{
    public CollectableSO collectedObj;

    void start()
    {
        if (collectedObj.collected)
        {
            Destroy(gameObject);
        }
    }
}
