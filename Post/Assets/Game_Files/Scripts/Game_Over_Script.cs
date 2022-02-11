using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Over_Script : MonoBehaviour
{
    public Text Points;

    public void Setup(int player_score)
    {
        gameObject.SetActive(true);
        if (player_score == 1)
        {
            Time.timeScale = 0;
            Points.text = player_score.ToString() + " POINT";
        }
        else
        {
            Time.timeScale = 0;
            Points.text = player_score.ToString() + " POINTS";
        }
    }


    public void Restart_Button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu_Button()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
