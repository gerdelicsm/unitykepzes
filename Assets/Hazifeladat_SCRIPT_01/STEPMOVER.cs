using UnityEngine;

class STEPMOVER : MonoBehaviour
{
    void Update()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);  //// GetKey --->folyamatos lenyomásra GetKeyDown ----> lenyomásra GetKeyUp---> felengedésre
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);

        if (up)
            transform.position += new Vector3(0, 1, 0);
        if (down)
            transform.position += Vector3.down;
        if (left)
            transform.position += Vector3.left;
        if (right)
            transform.position += Vector3.right;
    }
}
