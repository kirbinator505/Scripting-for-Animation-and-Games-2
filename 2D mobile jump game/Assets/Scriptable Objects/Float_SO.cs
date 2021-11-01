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

    public void LimitedAddToValue(float num, float limit)
    {
        if (value < limit)
        {
            value += num;
        }
    }

    public void ResetToZero()
    {
        value = 0f;
    }
}
