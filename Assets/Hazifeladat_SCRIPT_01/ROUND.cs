using UnityEngine;

 class ROUND : MonoBehaviour
{
    [SerializeField] float num;

    [SerializeField] float roundedDown;
    [SerializeField] float roundedUp;
    [SerializeField] float rounded;


    void OnValidate()
    {
        roundedDown = Floor(num);  //lefel� kerek�t�s ----> ugyanez behivatkozhat� Mathf.Floor
        roundedUp = Ceil(num); //felfel� kerek�t�s ----> ugyanez behivatkozhat� Mathf.Ceil
        rounded = Round(num); // kerek�t�s ----> ugyanez behivatkozhat� Mathf.Round
    }

    float Floor(float n)
    {
        float remainder = n % 1;
        return - remainder;
    }

    float Ceil(float n)
    {
        float remainder = n % 1;

        if (remainder == 0)
            return n;
        return n + (1 - remainder);
    }
    float Round(float n)
    {
        float remainder = n % 1;

        if (remainder < 0.5f)
            return Floor(n);
        else
            return Ceil(n);
    }
}
