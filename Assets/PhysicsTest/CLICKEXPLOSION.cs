using UnityEngine;

class CLICKEXPLOSION : MonoBehaviour
{
    [SerializeField] float maxForce;
    [SerializeField] float range;
    [SerializeField] float upward;
    [SerializeField] ParticleSystem ParticleSystem;
    [SerializeField] Rigidbody[] rigidbodies;
    Vector3 lastRayHit;

    void Start()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Camera cam = Camera.main;

            Vector3 mousePos = Input.mousePosition;

            Ray ray = cam.ScreenPointToRay(mousePos);
/*            Ray otherRay = new Ray(transform.position, transform.forward); */ /// <---- ha nem a kamera a kiindulopont

            bool doesHit = Physics.Raycast(ray, out RaycastHit hit);

            if (doesHit)
            {
                lastRayHit = hit.point;
                Debug.Log(hit.collider.name + "   " + hit.point);
                // ExplodeOne(lastRayHit);
                ExplodeAll(lastRayHit);
                transform.position = lastRayHit;
                ParticleSystem.Play();
            }
        }
    }
    void ExplodeAll(Vector3 pos) //unity sajat megoldasa
    {
        foreach (Rigidbody rb in rigidbodies)  //foreach ciklus ---> a ciklus minden elemen vegrehajtanado muvelet
        /*  for (int i = 0; i < rigidbodies.Length; i++)
          {
              Rigidbody rb = rigidbodies[i];
        */
        {
            rb.AddExplosionForce(maxForce, pos, range, upward, ForceMode.Impulse);
        }
    }
    void ExplodeOne(Vector3 pos) //oran irt megoldas
    {
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            Rigidbody rb = rigidbodies[i];

            Vector3 distanceVect = rb.transform.position - pos;
            float distance = distanceVect.magnitude;
            Vector3 direction = distanceVect / distance;

            if (distance < range)
            {
                float force = maxForce * (range - distance) / range;
                rb.AddForce(force * direction, ForceMode.Impulse);
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(lastRayHit, 0.2f);
    }
}
