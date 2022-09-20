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
        if (b != 0)
        {
            hanyados = a / b;
            maradek = a % b;
            torthanyados = (float)a / b;
        }
        else
        {
            hanyados = 0;
            maradek = 0;
            torthanyados = 0;
        }
        
    }
}
