using System.Collections;
using UnityEngine;

public class Packages_Spawner : MonoBehaviour
{
    public GameObject[] Packages;
    public float Spawn_Wait;
    public int Start_Wait;
    public bool stop;

    private int Pack_Type;

    void Start()
    {
        StartCoroutine(Packs_Spawner());
    }

    IEnumerator Packs_Spawner()
    {
        yield return new WaitForSeconds(Start_Wait);

        while(!stop)
        {
            Pack_Type = Random.Range(0, 5);
            Vector3 spawn_position = new Vector3(0.0f, 1.0f, -43f);

            Instantiate(Packages[Pack_Type], spawn_position + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(Spawn_Wait);
        }

    }

}
