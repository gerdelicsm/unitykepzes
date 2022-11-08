using UnityEngine;

class PlayerMover : MonoBehaviour
{
    //  [SerializeField] float offset;  // koordináta növelése DE!! képkockánként
    [SerializeField] float speed;   // sebesség megadása --> egységsebesség képfrissítéstõl függetlenül
    // [SerializeField] Vector3 velocity;  //sebesség megadása VEKTORként
    [SerializeField] float fordulasi;
    [SerializeField] Animator animator;

    void Update()    /// minden egyes képfrissítésnél meghívódik
    {
        // Inputkezelés
        bool up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        bool left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        float x = 0;
        if (right && !left)
            x = 1;
        else if (left && !right)
            x = -1;

        float z = 0;
        if (up && !down)
            z = 1;
        else if (down && !up)
            z = -1;

        Vector3 velocity = new Vector3(x, 0, z);
        velocity.Normalize();
        velocity *= speed;

        // Elmozdulás
        /*
        Vector3 position = transform.position;
        position.x += velocity * Time.deltaTime;
        transform.position = position;
    */
        transform.position += velocity * Time.deltaTime;

        bool isRunning = velocity != Vector3.zero;
        animator.SetBool("isRunning", isRunning);

        // fordulas
        if (isRunning)
        {
            Quaternion targetRot = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRot,
                fordulasi * Time.deltaTime);
        }
    }
}
