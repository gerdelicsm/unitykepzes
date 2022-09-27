using UnityEngine;

class GridLocker : MonoBehaviour
{
    [ExecuteInEditMode] /// ezzel a kit�tellel ez Edit Mode-ban is m�k�dik

    void Update()
    {
        Vector3 pos=transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = Mathf.Round(pos.z);
        transform.position = pos;
    }
}
