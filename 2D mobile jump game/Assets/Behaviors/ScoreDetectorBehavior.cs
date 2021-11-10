using UnityEngine;
using UnityEngine.Events;

public class ScoreDetectorBehavior : MonoBehaviour
{
    private bool pointAvailable;
    public UnityEvent addPoint;
    public Bool_SO gamePlaying;
    public Float_SO platform_speed;
    void Start()
    {
        pointAvailable = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (pointAvailable)
        {
            addPoint.Invoke();
            //pointAvailable = false;
        }
        Debug.Log("hit");
    }
/*
    private void Update()
    {
        if (gamePlaying.value)
        {
            transform.Translate(Vector3.down * Time.deltaTime * platform_speed.value);
        }
    }
    */
}
