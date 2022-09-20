using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;

    void Update()
    {
        Vector3 targetPoint = target.position;  //c�l be�ll�t�sa
        Vector3 SelfPosition = transform.position;
        /*
        Vector3 velocity = targetPoint - SelfPosition;
        velocity.Normalize();
        velocity *= speed; //sebess�g �rt�k be�ll�t�sa
        velocity *= Time.deltaTime;  //id�vel halad�s
        float stepDistance = velocity.magnitude; //t�vols�g r�gz�t�se a j�t�kost�l
        float targetDistance = Vector3.Distance(targetPoint, SelfPosition);  //t�vols�g meghat�roz�sa
        if(targetDistance<stepDistance)  //ha t�lhaladt, csak akkor�t ugorjon, mint a t�vols�ga
        {
            velocity.Normalize();
            velocity *= targetDistance;
        }

        transform.position += velocity;

        */
        float maxStep = speed * Time.deltaTime;             /// ez ugyanaz, mint a fenti
        transform.position = Vector3.MoveTowards(SelfPosition, targetPoint, maxStep);
        transform.rotation = Quaternion.LookRotation(-targetPoint-SelfPosition);
    }
}