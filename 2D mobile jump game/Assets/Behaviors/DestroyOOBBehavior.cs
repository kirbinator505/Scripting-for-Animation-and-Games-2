using UnityEngine;

public class DestroyOOBBehavior : MonoBehaviour
{
    public Float_SO LowerBound;

    void Update()
    {
        if (transform.position.y < LowerBound.value)
        {
            Destroy(gameObject);
        }
    }
}
