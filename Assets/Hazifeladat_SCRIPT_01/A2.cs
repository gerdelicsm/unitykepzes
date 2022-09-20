using UnityEngine;

class A2 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int hanyados;
    [SerializeField] int maradek;
    [SerializeField] float torthanyados;

    void OnValidate()
    {
        hanyados = a / b;
        maradek = a % b;
        torthanyados = (float)a / b;
    }
}
