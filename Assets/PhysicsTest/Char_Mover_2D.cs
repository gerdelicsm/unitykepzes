using UnityEngine;

class Char_Mover_2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float force;
    [SerializeField] float speed;
    [SerializeField] int airJumps = 1;
    [SerializeField] int moveForce = 1;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask canJumpLayer;

    bool OnGround = false;
    int jumpCounts = 0;

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
        //
        //GetComponentInChildren<Collider2D>;
        //GetComponentInChildren<SpriteRenderer>; //*
    }

    void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.UpArrow);  //getkeydown-nál jobb az impulse force vagy ha nem számít a tömeg velocity change
        /*    bool left = Input.GetKey(KeyCode.LeftArrow);
            bool right = Input.GetKey(KeyCode.RightArrow); */  //sajátmegoldás

        if (jump && (OnGround || jumpCounts > 0))
        {
            Vector2 v = rigidbody.velocity;
            v.y = 0;
            rigidbody.velocity = v;

            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            jumpCounts--;
        }
        /* float x = 0;
        if (left)
            x = -1;
        if (right)
            x = 1;

        Vector3 velocity = new Vector2(x, 0);
        velocity *= speed;

        transform.position += velocity * Time.deltaTime;*/ ///saját megoldás volt
    }

    void FixedUpdate()  //folytonos mozgást mindig fixedupdate-ben érdemes
    {
        float direction = Input.GetAxis("Horizontal");

        if (OnGround)
        {
            Vector2 v = rigidbody.velocity;
            v.x = direction * speed;
            rigidbody.velocity = v;
        }
        else
        {
            rigidbody.AddForce(Vector2.right * direction * moveForce, ForceMode2D.Force);  //folyamatos erõnél force módban érdemes használni, ha számít a tömeg akkor acceleration

            Vector2 v = rigidbody.velocity;
            float dir = Mathf.Sign(v.x);
            float horizontalSpeed = Mathf.Abs(v.x);
            v.x = Mathf.Min(horizontalSpeed, speed) * dir;
            rigidbody.velocity = v;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        int layer = collision.gameObject.layer;
        {
            OnGround = false;
            Debug.Log("STAY:" + collision.collider.name);
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Hit" + collision.collider.name);
            OnGround = true;
            jumpCounts = airJumps + 1;
        }
    }
}
