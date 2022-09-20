using UnityEngine;

class A7 : MonoBehaviour
{
    [SerializeField] float sugar;
    [SerializeField] float kerulet;
    [SerializeField] float terulet;

    void OnValidate()
    {
        kerulet = 2 * sugar * 3.14f;
        terulet = sugar * sugar * 3.14f;
    }
}
