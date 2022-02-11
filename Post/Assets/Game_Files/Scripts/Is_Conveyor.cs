using UnityEngine;

public class Is_Conveyor : MonoBehaviour
{
    [SerializeField]
    private Packages_Movement Pack_Move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Conv")
        {
            Pack_Move.IsConveyor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Conv")
        {
            Pack_Move.IsConveyor = false;
        }
    }



}
