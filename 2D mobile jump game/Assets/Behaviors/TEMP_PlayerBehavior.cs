using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class TEMP_PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Vector2 direction; //temp
    public Float_SO Player_Height;
    private float jumpforce = 10f;
    public UnityEvent SetGamePlaying, gameStop;
    public Bool_SO gamePlaying, gameActive;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (gameActive.value)
        {
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpforce;
                playerRB.AddForce(direction, ForceMode2D.Impulse);
                if (gamePlaying.value == false) //bring this into the updated player mover, have it on mouse or touch up or smthn, makes it so SetGamePlaying is only invoked once
                {
                    SetGamePlaying.Invoke();
                }
            }

            Player_Height.value = playerRB.position.y;
        }
    }
}
