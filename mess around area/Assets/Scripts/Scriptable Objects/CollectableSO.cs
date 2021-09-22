using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CollectableSO : ScriptableObject
{
    public bool collected;
    public int costValue;
    public GameObject art3d;
    public Sprite art2d;
    public Color artColorTint = Color.blue;
}
