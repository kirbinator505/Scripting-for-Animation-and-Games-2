using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOOBBehavior : MonoBehaviour
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
