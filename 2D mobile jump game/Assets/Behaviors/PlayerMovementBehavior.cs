using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementBehavior : MonoBehaviour
{
    public Vector2 mouseDown, mouseUp, launchDirection;
    private Rigidbody2D playerRB;
    public Float_SO playerHeight;
    public UnityEvent setGamePlaying;
    public Bool_SO gamePlaying, gameActive;
    private bool jumpAvailable;
    private void OnMouseDown()
    {
        mouseDown = Input.mousePosition;
    }

    public void OnMouseUp()
    {
        mouseUp = Input.mousePosition;

        launchDirection.x = (mouseDown.x - mouseUp.x);
        launchDirection.y = (mouseDown.y - mouseUp.y);
        if (launchDirection.y > 100)
        {
            launchDirection.y = 100;
        }
        if (launchDirection.x < -50)
        {
            launchDirection.x = -50;
        }
        if (launchDirection.x > 50)
        {
            launchDirection.x = 50;
        }

        if (gameActive.value)
        {
            if (jumpAvailable)
            {
                playerRB.AddForce(launchDirection, ForceMode2D.Impulse);
                if (gamePlaying.value == false)
                {
                    setGamePlaying.Invoke();
                }

                jumpAvailable = false;
            }
        }
    }

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        jumpAvailable = true;
    }

    void Update()
    {
        playerHeight.value = playerRB.position.y;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumpAvailable = true;
    }
}
