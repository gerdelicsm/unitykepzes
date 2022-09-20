using UnityEngine;

class B1 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] bool oszthato7;
    [SerializeField] bool oszthato15;
    [SerializeField] bool oszthato99;

    void OnValidate()
    {
        if (a % 7 == 0)
            oszthato7 = true;
        else
            oszthato7 = false;

        if (a % 15 == 0)
            oszthato15 = true;
        else
            oszthato15 = false;

        if (a % 99 == 0)
            oszthato99 = true;
        else
            oszthato99 = false;
    }
}
