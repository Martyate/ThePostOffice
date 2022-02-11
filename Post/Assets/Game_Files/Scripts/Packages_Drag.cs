using UnityEngine;

public class Packages_Drag : MonoBehaviour
{
    private Rigidbody Dragging_Packages;
    private Transform Dragging_Movement;

    private Vector3 Previous_Pos;
    private Vector3 distance;

    private float X_Pos;
    private float Y_Pos;

    private bool Is_Touched = false;
    private bool Is_Dragging = false;

    public Camera Position_Calculator;

    private void SetDraggingProperties(Rigidbody dragging_obj)
    {
        dragging_obj.useGravity = false;
        dragging_obj.drag = 20;
    }



    private void SetFreeDraggingProperties(Rigidbody dragging_obj)
    {
        dragging_obj.useGravity = true;
        dragging_obj.drag = 0;
    }



    void FixedUpdate()
    {
        if(Input.touchCount != 1)
        {
            Is_Touched = false;
            Is_Dragging = false;
            if(Dragging_Packages)
                SetFreeDraggingProperties(Dragging_Packages);
            return;
        }

        Touch touches = Input.touches[0];
        Vector3 pos = touches.position;

        if(touches.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Position_Calculator.ScreenPointToRay(pos);

            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Red" || hit.collider.tag == "Green" || hit.collider.tag == "Blue" || hit.collider.tag == "Purple" || hit.collider.tag == "Yellow"))
            {
                Dragging_Movement = hit.transform;
                Previous_Pos = Dragging_Movement.position;
                Dragging_Packages = Dragging_Movement.GetComponent<Rigidbody>();

                distance = Position_Calculator.WorldToScreenPoint(Previous_Pos);
                X_Pos = Input.GetTouch(0).position.x - distance.x;
                Y_Pos = Input.GetTouch(0).position.y - distance.y;

                SetDraggingProperties(Dragging_Packages);

                Is_Touched = true;

            }
        }

        if (touches.phase == TouchPhase.Moved && Is_Touched)
        {
            Is_Dragging = true;

            float New_X_Pos = Input.GetTouch(0).position.x - X_Pos;
            float New_Y_Pos = Input.GetTouch(0).position.y - Y_Pos;

            Vector3 current_pos = new Vector3(New_X_Pos, New_Y_Pos, distance.z);
            Vector3 current_world_pos = Position_Calculator.ScreenToWorldPoint(current_pos) - Previous_Pos;
            current_world_pos = new Vector3(current_world_pos.x, current_world_pos.y, 0.0f);

            Dragging_Packages.velocity = current_world_pos / (Time.deltaTime * 10);

            Previous_Pos = Dragging_Movement.position;
        }

        if (touches.phase == TouchPhase.Ended || touches.phase == TouchPhase.Canceled && Is_Dragging)
        {
            Is_Dragging = false;
            Is_Touched = false;
            Previous_Pos = new Vector3(0.0f, 0.0f, 0.0f);

            SetFreeDraggingProperties(Dragging_Packages);
        }



    }
}
