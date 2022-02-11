using UnityEngine;
using UnityEngine.UI;

public class Points_On_Screen : MonoBehaviour
{
    public Text Score;

    public void Score_Counter(int player_score)
    {
            Score.text = "SCORE: " + player_score.ToString();
    }
}
