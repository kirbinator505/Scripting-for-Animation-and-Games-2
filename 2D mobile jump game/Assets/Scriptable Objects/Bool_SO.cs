using UnityEngine;

[CreateAssetMenu]
public class Bool_SO : ScriptableObject
{
    public bool value;

    public void SetFalse()
    {
        value = false;
    }

    public void SetTrue()
    {
        value = true;
    }
}
