using UnityEngine;

class STEPCOUNT : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;

    void OnValidate()
    {
        stepCount = Mathf.CeilToInt (Vector2.Distance(a, b));  ///Mathf.CeilToInt ---> egyb�l int-be alak�tja 
        step = (b - a)/stepCount;
    }
}
