using UnityEngine;

class A3 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] int d;
    [SerializeField] int e;
    [SerializeField] float atlag;

    void OnValidate()
    {
        atlag = (a + b + c + d + e) / 5f; 
    }

}
