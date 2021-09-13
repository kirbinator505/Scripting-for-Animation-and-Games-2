using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehavior : MonoBehaviour
{
    public float holdTime = 2f;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        Destroy(gameObject);
    }
}
