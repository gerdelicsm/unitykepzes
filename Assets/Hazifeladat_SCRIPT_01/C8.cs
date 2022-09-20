using UnityEngine;

public class C8 : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        for (int i=1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Debug.Log($"{i}+FizzBuzz");
            else if (i % 3 == 0)
                Debug.Log($"{i}+Fizz");
            else if (i % 5 == 0)
                Debug.Log($"{i}+Buzz");
            else
                Debug.Log($"{i}");
        }
    }
}
