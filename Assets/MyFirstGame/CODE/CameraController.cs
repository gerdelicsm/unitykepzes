using UnityEngine;

 class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float horizontalDistance;
    [SerializeField] float height;

    void LateUpdate()
    {
        Vector3 direction = target.position - transform.position;
       transform.rotation = Quaternion.LookRotation(direction);

        Vector3 offsetHorizontal = -target.forward * horizontalDistance;
        Vector3 offsetVertical = new Vector3(0, height, 0);
        Vector3 cameraPos = target.position + offsetHorizontal+offsetVertical;
        transform.position = cameraPos;
    }
}
