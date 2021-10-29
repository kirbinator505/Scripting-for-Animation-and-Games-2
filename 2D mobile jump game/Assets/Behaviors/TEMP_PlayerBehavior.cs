using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class TEMP_PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Vector2 direction; //temp
    public Float_SO Player_Height;
    private float jumpforce = 10f;
    public UnityEvent SetGameActive;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpforce;
            playerRB.AddForce(direction, ForceMode2D.Impulse);
            SetGameActive.Invoke();
        }
        Player_Height.value = playerRB.position.y;
    }
}