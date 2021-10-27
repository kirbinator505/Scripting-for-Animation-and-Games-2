using UnityEngine;
using UnityEngine.Events;

public class DetectOOBBehavior : MonoBehaviour
{
    public Float_SO LowerBound;

    void Update()
    {
        if (transform.position.y < LowerBound.value)
        {
            gameObject.SetActive(false);
        }
    }
}
