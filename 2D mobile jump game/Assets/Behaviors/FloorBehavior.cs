using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class FloorBehavior : MonoBehaviour
{
    private Rigidbody2D body;
    public Float_SO bottomLimit;
    public Bool_SO gamePlaying;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void MoveFloor()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (gamePlaying.value == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.5f);
        }

        if (body.position.y < bottomLimit.value)
        {
            gameObject.SetActive(false);
        }
    }
}
