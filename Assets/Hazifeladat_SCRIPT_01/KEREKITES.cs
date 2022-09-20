using UnityEngine;

class KEREKITES : MonoBehaviour
{
    [SerializeField] float number
    [SerializeField] int kerekitve

    void OnValidate()
    {
        bool felfele=number+0.51f;

        if (felfele == true)
            return number + 0.51f;
        else
            return number;
    }

}
