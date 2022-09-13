using UnityEngine;

class ControlStructurePractice : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string pairity;
    [SerializeField] string positivity;

    // Sequence tipusu metodusok
    void OnValidate()
    {

        int int2 = number % 2;
        pairity = "";

        bool isEven = number % 2 == 0;
        if (isEven)
        {
            pairity = "PAROS";
        }
        else
        {
            pairity = "PARATLAN";
        }
        // if, else, if-else --< ha több variáció van

        bool isPositive;
        if (number < 0)
        {
            positivity = "NEGATIV";
        }
        else if (number > 0)
        {
            positivity = "POZITÍV";
        }
        else
        {
            positivity = "NULLA";
        }
        // switch tipusu elagazas is van, de azt itt nem vesszuk
    }
    // Selection (elagazo) metodusok
    void Start()
    {
        //loop ciklus
        int i = 1;
        while (i <= 100)
        {
            int i2 = i * i;
            Debug.Log(i);
            i++;
            //noveles
        }
        //egyesével növelés 10-ig
        for (int j = 1; j <= 10; j++)
        {
            Debug.Log(j);
        }
    }
}
