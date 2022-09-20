using UnityEngine;

class D5 : MonoBehaviour
{
    [SerializeField] float Szam;
    [SerializeField] float Abszolut;

    void OnValidate()
    {
        if (Szam > 0)
        { Abszolut = Szam; }
        else if (Szam < 0)
        { Abszolut = -Szam; }
        else
        { Abszolut = 0; }
    }
}
