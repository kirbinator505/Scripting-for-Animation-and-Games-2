using UnityEngine.UI;
using UnityEngine;

public class ScoreBehavior : MonoBehaviour
{
    public Text txt;
    public Float_SO score;
    void Update()
    {
        txt.text = "Score: " + score.value;
    }
}
