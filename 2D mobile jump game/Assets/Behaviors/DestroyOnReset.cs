using UnityEngine;

public class DestroyOnReset : MonoBehaviour
{
    public Bool_SO gamePlaying;
    public void Update()
    {
        if (gamePlaying.value == false)
        {
            Destroy(gameObject);
        }
    }
}
