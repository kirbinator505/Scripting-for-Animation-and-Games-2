using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner_behavior : MonoBehaviour
{
    public GameObject Obj;
    private Transform point;
    public Float_SO Delay;
    public float random;

    public void StartSpawner()
    {
        point = GetComponent<Transform>();
        InvokeRepeating(nameof(SpawnObj), 0, Delay.value);
        
    }

    void SpawnObj()
    {
        random = Random.Range(1f, 4f);
        if (random <= 3)
        {
            Instantiate<GameObject>(Obj, point);
        }
    }

    public void Stop()
    {
        CancelInvoke(nameof(SpawnObj));
    }
}
