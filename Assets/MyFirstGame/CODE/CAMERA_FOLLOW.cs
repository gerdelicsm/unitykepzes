using UnityEngine;

public class CAMERA_FOLLOW : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 10;

    void Update()
    {
        Vector3 targetPoint = target.position;  //cél beállítása
        Vector3 SelfPosition = transform.position;

        float maxStep = speed * Time.deltaTime;             /// ez ugyanaz, mint a fenti
        transform.position = Vector3.MoveTowards(SelfPosition, targetPoint, maxStep);

        if (targetPoint != SelfPosition) // ne legyen 0 felé nézve hibaüzenet
        {
            transform.rotation = Quaternion.LookRotation(targetPoint - SelfPosition);
        }
    }
}
