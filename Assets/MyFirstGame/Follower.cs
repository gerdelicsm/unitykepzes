using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;
    [SerializeField] AnimationCurve SpeedOverDistance;

    void Update()
    {
        Vector3 targetPoint = target.position;  //cél beállítása
        Vector3 SelfPosition = transform.position;
        /*
        Vector3 velocity = targetPoint - SelfPosition;
        velocity.Normalize();
        velocity *= speed; //sebesség érték beállítása
        velocity *= Time.deltaTime;  //idõvel haladás
        float stepDistance = velocity.magnitude; //távolság rögzítése a játékostól
        float targetDistance = Vector3.Distance(targetPoint, SelfPosition);  //távolság meghatározása
        if(targetDistance<stepDistance)  //ha túlhaladt, csak akkorát ugorjon, mint a távolsága
        {
            velocity.Normalize();
            velocity *= targetDistance;
        }

        transform.position += velocity;

        */
        float distance = Vector3.Distance(transform.position, target.position);
        float speed = SpeedOverDistance.Evaluate(distance);
        float maxStep = speed * Time.deltaTime;             /// ez ugyanaz, mint a fenti
        transform.position = Vector3.MoveTowards(SelfPosition, targetPoint, maxStep);

        if (targetPoint != SelfPosition) // ne legyen 0 felé nézve hibaüzenet
        { 
            transform.rotation = Quaternion.LookRotation(targetPoint - SelfPosition); 
        }
    }
}
