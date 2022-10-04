using UnityEngine;

class Legnagyobkozososzto : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int gcd;

    void OnValidate()
    {
        gcd = GreatestCommonDivisor(a, b);
    }

    int GreatestCommonDivisor(int a, int b)
    {
        int min = Mathf.Min(a, b);
        int greatest = 0;
        for (int i = 2; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0)
                greatest = i;
        }
        return greatest;
    }
}
