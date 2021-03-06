using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FloorBehavior : MonoBehaviour
{
    private Rigidbody2D body;
    public Bool_SO gamePlaying;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gamePlaying.value == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.5f);
        }

        if (body.transform.position.y < -6)
        {
            gameObject.SetActive(false);
        }
    }
}
