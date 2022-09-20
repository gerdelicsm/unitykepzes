using UnityEngine;

class A8 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;

    void Start()
    {
        int csere = a;
        a = b;
        b = csere;
    }
}
