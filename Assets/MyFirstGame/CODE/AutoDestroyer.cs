using UnityEngine;

class AutoDestroyer : MonoBehaviour
{
    [SerializeField] float destructionTime;
    float startTime;
    [SerializeField] GameObject go;
    [SerializeField] MonoBehaviour mb;

    void Test()
    {
        go.SetActive(true); // gameobject bekapcsol�sa
        go.SetActive(false); // gameobject kikapcsol�sa

        Debug.Log("Be van kapcsolva �s minden sz�l�je" + go.activeInHierarchy); // game object active-e minden sz�l�j�vel lek�rdez�s
        Debug.Log("Be van kapcsolva" + go.activeSelf); // a konkr�t object akt�v-e

        mb.enabled = false; // komponenes kikapcs/bekapcs
        mb.enabled = true;
    }
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

    void Awake()  //object l�trej�ttekor
    {
        Debug.Log("Bullet Awaken");
    }
    void OnDestroy() //object megsz�n�sekor
    {
        Debug.Log("Bullet Destroyed");
    }

    void OnEnable() // object bekapcsol�sakor
    {
        Debug.Log("Bullet Enabled");
    }

    void OnDisable()  // object kikapcsol�sakor
    {
        Debug.Log("Bullet Disabled");
    }
}
