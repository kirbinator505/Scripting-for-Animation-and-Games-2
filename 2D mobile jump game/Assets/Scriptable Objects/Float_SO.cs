using UnityEngine;

[CreateAssetMenu]
public class Float_SO : ScriptableObject
{
    public float value;

    public void AddToValue(float num)
    {
        value += num;
    }

    public void ResetValue(float num)
    {
        value = num;
    }

    public void HalfValue(float num)
    {
        value = num / 2;
    }

    public void ResetToZero()
    {
        value = 0f;
    }
}
