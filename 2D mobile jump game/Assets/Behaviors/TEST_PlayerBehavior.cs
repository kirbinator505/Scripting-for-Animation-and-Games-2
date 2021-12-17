using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TEST_PlayerBehavior : MonoBehaviour
{
    public Float_SO playerHeight;
    private Rigidbody2D playerRB;
    public Bool_SO jumpAvailable;
    public Vector2_SO launchDirection;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        playerHeight.value = playerRB.position.y;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Platform"))
            jumpAvailable.value = true;
    }

    public void LaunchPlayer()
    {
        playerRB.AddForce(launchDirection.value, ForceMode2D.Impulse);
        jumpAvailable.value = false;
    }
}
