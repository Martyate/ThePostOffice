using UnityEngine;

public class Packages_Movement : MonoBehaviour
{
    [SerializeField]
    Rigidbody Pack;
    public float packs_speed = 0.03f;

    private bool Is_Conveyor;

    public bool IsConveyor
    {
        get
        {
            return Is_Conveyor;
        }
        set
        {
            Is_Conveyor = value;
        }
    }

    void Start()
    {
        Pack = GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        if (Is_Conveyor)
        {
            Pack.transform.Translate(0, 0, packs_speed, Space.World);
        }
        packs_speed += 0.00001f;
    }
}
