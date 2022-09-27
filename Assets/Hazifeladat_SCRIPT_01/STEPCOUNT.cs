using UnityEngine;

class STEPCOUNT : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;

    void OnValidate()
    {
        stepCount = Mathf.CeilToInt (Vector2.Distance(a, b));  ///Mathf.CeilToInt ---> egybõl int-be alakítja 
        step = (b - a)/stepCount;
    }
}
