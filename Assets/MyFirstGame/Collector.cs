using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    
    int collectedValue;

    void Start()
    {
        FreshText();  //beh�vja a sz�veget
    }

    void OnTriggerEnter(Collider other) //�tk�z�s eset�n
    {
        Collectable c = other.GetComponent<Collectable>();   ///beh�vja a collectable komponenset
        if (c != null)
        {
            collectedValue += c.value; //n�veli a c �rt�k�t, ha nem nulla
            c.TeleportRandom();  /// beh�vja a collectable teleport random �rt�k�t
            ///            Debug.Log("new value: " + collectedValue);
            FreshText();
        }
    }

    void FreshText()  ////f�ggv�ny a score ki�r�sra
    {
        if (scoreText != null)
            scoreText.text = $"Score: {collectedValue}";
    }
}
