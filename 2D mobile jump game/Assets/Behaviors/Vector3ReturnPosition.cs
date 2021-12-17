using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Vector3ReturnPosition : MonoBehaviour
{
    public Vector3_SO returnPosition;
    public Transform objTransform;

    void start()
    {
        objTransform = GetComponent<Transform>();
    }

    public void ResetTransform()
    {
        objTransform.position = returnPosition.position;
    }
}
