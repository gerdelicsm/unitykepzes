using UnityEngine;

class AutoDestroyer : MonoBehaviour
{
    [SerializeField] float destructionTime;
    float startTime;
    [SerializeField] GameObject go;
    [SerializeField] MonoBehaviour mb;

    void Test()
    {
        go.SetActive(true); // gameobject bekapcsolása
        go.SetActive(false); // gameobject kikapcsolása

        Debug.Log("Be van kapcsolva és minden szülõje" + go.activeInHierarchy); // game object active-e minden szülõjével lekérdezés
        Debug.Log("Be van kapcsolva" + go.activeSelf); // a konkrét object aktív-e

        mb.enabled = false; // komponenes kikapcs/bekapcs
        mb.enabled = true;
    }
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

    void Awake()  //object létrejöttekor
    {
        Debug.Log("Bullet Awaken");
    }
    void OnDestroy() //object megszûnésekor
    {
        Debug.Log("Bullet Destroyed");
    }

    void OnEnable() // object bekapcsolásakor
    {
        Debug.Log("Bullet Enabled");
    }

    void OnDisable()  // object kikapcsolásakor
    {
        Debug.Log("Bullet Disabled");
    }
}
