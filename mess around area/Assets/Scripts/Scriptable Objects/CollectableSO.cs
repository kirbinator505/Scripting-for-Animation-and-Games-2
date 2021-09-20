using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CollectableSO : ScriptableObject
{
    public bool collected;
    public int costValue;
    public GameObject art;
    public Color artColorTint = Color.blue;
}
