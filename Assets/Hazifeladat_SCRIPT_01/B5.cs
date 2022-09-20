using UnityEngine;

class B5 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] bool szamharmas;

    void OnValidate()
    {
        if ((a * a) + (b * b) == (c * c))
        { szamharmas = true; }
        else
        { szamharmas = false; }
    }
}
