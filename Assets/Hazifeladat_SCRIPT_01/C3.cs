using UnityEngine;

class C3 : MonoBehaviour
{
    [SerializeField] int n;
    [SerializeField] string szamsor;

    void OnValidate()
    {
        szamsor = "";

        for (int i = 1; i <= n; i++)
        {
            szamsor = szamsor+i+",";
        }
    }

}
