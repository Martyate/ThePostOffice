using UnityEngine;

public class Game_Manager_Script : MonoBehaviour
{
    [SerializeField]
    Game_Over_Script game_over;
    public int score = 0;
    public float Restart_Delay = 1f;

    private bool Game_Was_Ended = false;
    public void End_Game(int score)
    {
        if (Game_Was_Ended == false)
        {
            Game_Was_Ended = true;

            game_over.Setup(score);
        }
    }
}