using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawnerBehavior : MonoBehaviour
{
    public GameObject Obj;
    private Transform point;
    public Float_SO Delay;

    public void StartSpawner()
    {
        point = GetComponent<Transform>();
        InvokeRepeating(nameof(SpawnObj), 0, Delay.value);
        
    }

    void SpawnObj()
    {
        Instantiate<GameObject>(Obj, point);
    }

    public void Stop()
    {
        CancelInvoke(nameof(SpawnObj));
    }
}
