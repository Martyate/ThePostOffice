using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_Yellow : MonoBehaviour
{
    [SerializeField]
    Game_Manager_Script Game_Manager;
    [SerializeField]
    Points_On_Screen Points_On_Screen;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Yellow")
        {
            Game_Manager.score++;
            FindObjectOfType<Points_On_Screen>().Score_Counter(Game_Manager.score);
            Destroy(other.gameObject);
        }

        else
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }
    }
}
