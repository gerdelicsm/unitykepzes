using UnityEngine;

class AutoDestroyer : MonoBehaviour
{
    [SerializeField] float destructionTime;
    float startTime;


    void Start()
    {
        startTime = Time.time;  //létrehozunk egy változót a létrehozás idejére
    }

    void Update()
    {
        float currentTime = Time.time;  //hivatkozunk a jelen idõre

        if (startTime + destructionTime < currentTime)  //a létrejött idõpontja és a megadott elpusztítási idõ nagyobb mint a jelen idõ
        {
            Destroy(gameObject);  //Destroy-jal lehet megszüntetni az adott gameobjectet
        }
    }
}
