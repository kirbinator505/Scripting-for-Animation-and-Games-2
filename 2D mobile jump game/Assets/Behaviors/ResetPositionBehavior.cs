using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class ResetPositionBehavior : MonoBehaviour
{
    public Vector2_SO returnPosition;
    public Transform objTransform;

    void start()
    {
        objTransform = GetComponent<Transform>();
    }

    public void ResetTransform()
    {
        objTransform.position = returnPosition.value;
    }
}