using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformspeedmanager : MonoBehaviour
{
    public Float_SO speed, spawnDelay;
    public float speedLimit, spawnDelayLimit, speedAdd, spawnSub;

    public void LimitedAdd()
    {
        if (speed.value < speedLimit)
        {
            speed.value += speedAdd;
        }
    }

    public void LimitedSubtract()
    {
        if (spawnDelay.value > spawnDelayLimit)
        {
            spawnDelay.value -= spawnSub;
        }
    }
}