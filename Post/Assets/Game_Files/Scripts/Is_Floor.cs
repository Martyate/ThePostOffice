using UnityEngine;

public class Is_Floor : MonoBehaviour
{
    [SerializeField]
    Game_Manager_Script Game_Manager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Purple")
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Red")
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Green")
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Yellow")
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Blue")
        {
            FindObjectOfType<Game_Manager_Script>().End_Game(Game_Manager.score);
            Destroy(other.gameObject);
        }
    }
}