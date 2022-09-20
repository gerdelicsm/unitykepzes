using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float n1, n2, n3, n4, n5;
    [Space] // <---- csak UI form�z�sra
    [SerializeField] float max;

    void OnValidate()
    {
        max = Maximum(n1, n2, n3, n4, n5);
    }
    void Start()
    {
        LogSqr(1, 5);
        LogSqr(10, 20);
        LogSqr(3, 7);

        LogSqr(12, 8); //nem fog kiadni semmit

        float f1 = Power(0.2f, 5);
        float f2 = Power(3f, 4);
    }

    //ez a metodus nem fut le magatol, be kell h�vni a masik altal
    // metodus lehet eljaras (void) - csak bemenete van, de nincs kimenete
    // metodus lehet fuggveny - ehhez kell tipus
    void LogSqr(int start, int end) // n-nel beh�vhat� m�s sz�m fent a startn�l - m�s param�ter
    {
        for (int i = start; i <= end; i++) //<----novelodik
        {
            Debug.Log(i * i);
        }
    }
    float Power(float baseNumber, int exponent) // <-----hatvanyozas
    {
        float number = 1;
        for (int i = 0; i < exponent; i++)
        {
            number = number * baseNumber;
        }
        return number;
    }
    float Minimum(float a, float b) // <-----kisebbik sz�m
    {
        {              // <------- saj�t megold�s
            if (a < b)
                return a;
            else
                return b;
        }
    }
    float Maximum(float a, float b) // <------ nagyobbik sz�m
    {
        if (a < b)
            return b;
        else
            return a;
    }
    float Maximum(float a, float b, float c) // <------ nagyobbik sz�m
    {
        if (a > b && a > c)
        {
            return a;
        }

        if (b > c)
        {
            return b;
        }

        else
        {
            return c;
        }
    }
    float Maximum(float a, float b, float c, float d, float e)  /// <----- j�val t�bb elemre
    {
        float max = Maximum(a, b);
        max = Maximum(max, c);
        max = Maximum(max, d);
        max = Maximum(max, e);

        return max;
    }
}
