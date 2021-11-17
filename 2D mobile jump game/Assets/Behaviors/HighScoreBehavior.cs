using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HighScoreBehavior : MonoBehaviour
{
    public Float_SO score, highScore;
    public Text text;
    public UnityEvent resetScore;
    
    void Start()
    {
        resetScore.Invoke();
    }


    void Update()
    {
        if (score.value > highScore.value)
        {
            highScore.value = score.value;
        }

        text.text = "High Score: " + highScore.value;
    }
}
