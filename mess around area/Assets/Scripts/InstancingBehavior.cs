using UnityEngine;

public class InstancingBehavior : MonoBehaviour
{
    public void OnInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
