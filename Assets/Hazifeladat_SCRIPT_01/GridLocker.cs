using UnityEngine;

class GridLocker : MonoBehaviour
{
    [ExecuteInEditMode] /// ezzel a kitétellel ez Edit Mode-ban is mûködik

    void Update()
    {
        Vector3 pos=transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = Mathf.Round(pos.z);
        transform.position = pos;
    }
}
