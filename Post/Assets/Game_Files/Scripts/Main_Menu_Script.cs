using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Script : MonoBehaviour
{
    public void Start_Button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TheGame");
    }
}