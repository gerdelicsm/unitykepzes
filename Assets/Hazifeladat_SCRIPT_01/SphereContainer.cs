using UnityEngine;

public class SphereContainer : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] Vector3 center;

    void Update()
    {
        Vector3 p = transform.position;

        float distance = Vector3.Distance(center, transform.position);
        if (distance > radius)
        {
            Vector3 offset = (p - center).normalized * radius;
            transform.position = center + offset;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(center, radius);
    }
}
