using UnityEngine;
using static UnityEngine.Vector3;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlatformBehavior : MonoBehaviour
{
    private Collider2D solid;
    private Rigidbody2D body;
    public Float_SO player_height, platform_speed, player_obj_height;

    private void Awake()
    {
        solid = GetComponent<Collider2D>();
        body = GetComponent<Rigidbody2D>();
        solid.isTrigger = true; //sets the collider to trigger on awake
    }

    void Update()
    {
        if (body.position.y < player_height.value - player_obj_height.value)
        {
            solid.isTrigger = false; //sets the collider to no longer be a trigger so it stops the player
        }
        else if (body.position.y > player_height.value + player_obj_height.value)
        {
            solid.isTrigger = true; //sets the collider to trigger if the player falls below it
        }

        transform.Translate(Vector3.down * Time.deltaTime * platform_speed.value);
    }
}
