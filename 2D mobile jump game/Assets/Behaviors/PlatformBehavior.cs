using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformBehavior : MonoBehaviour
{
    private Collider2D solid;
    private Rigidbody2D body;
    public Float_SO player_height;

    private void Awake()
    {
        solid = GetComponent<Collider2D>();
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (body.position.y < player_height.value)
        {
            solid.isTrigger = false; //sets the collider to no longer be a trigger so it stops the player
        }
            
    }
}
