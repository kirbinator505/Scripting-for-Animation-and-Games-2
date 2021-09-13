using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehavior : MonoBehaviour
{
    public float force;
    private Rigidbody RB;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddExplosionForce(20, Vector3.forward, force);
    }

    
}
