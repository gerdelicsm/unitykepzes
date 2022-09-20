using UnityEngine;

class C4 : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int summa;

    void OnValidate()
    {
        summa = 0;

        for (int i = 1; i <= number; i++)
            summa += i;
    }
}
