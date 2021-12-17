using UnityEngine;

public class Platformspeedmanager : MonoBehaviour
{
    public Float_SO speed, spawnDelay, backGroundSpeed;
    public float speedLimit, spawnDelayLimit, speedAdd, spawnSub, backgroundSpeedAdd;

    public void LimitedAdd()
    {
        if (speed.value < speedLimit)
        {
            speed.value += speedAdd;
            backGroundSpeed.value += backgroundSpeedAdd;
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