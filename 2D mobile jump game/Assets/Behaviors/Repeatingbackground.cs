using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Repeatingbackground : MonoBehaviour
{
    private Rigidbody2D body;
    public Bool_SO gamePlaying;
    public Float_SO backGroundSpeed;
    public Vector3 startPos;
    public double lowerBound = -0.506;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlaying.value)
        {
            transform.Translate(Vector3.down * Time.deltaTime * backGroundSpeed.value);
        }

        if (body.position.y <= lowerBound)
        {
             transform.position = startPos;
        }
    }
}
