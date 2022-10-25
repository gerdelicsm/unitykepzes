using UnityEngine;

class AutoDestroyer : MonoBehaviour
{
    [SerializeField] float destructionTime;
    float startTime;


    void Start()
    {
        startTime = Time.time;  //l�trehozunk egy v�ltoz�t a l�trehoz�s idej�re
    }

    void Update()
    {
        float currentTime = Time.time;  //hivatkozunk a jelen id�re

        if (startTime + destructionTime < currentTime)  //a l�trej�tt id�pontja �s a megadott elpuszt�t�si id� nagyobb mint a jelen id�
        {
            Destroy(gameObject);  //Destroy-jal lehet megsz�ntetni az adott gameobjectet
        }
    }
}
