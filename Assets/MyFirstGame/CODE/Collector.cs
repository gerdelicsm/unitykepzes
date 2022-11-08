using TMPro;
using UnityEngine;

class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    
    int collectedValue;

    void Start()
    {
        FreshText();  //behívja a szöveget
    }

    void OnTriggerEnter(Collider other) //ütközés esetén
    {
        Collectable c = other.GetComponent<Collectable>();   ///behívja a collectable komponenset
        if (c != null)
        {
            collectedValue += c.value; //növeli a c értékét, ha nem nulla
            c.TeleportRandom();  /// behívja a collectable teleport random értékét
            ///            Debug.Log("new value: " + collectedValue);
            FreshText();
        }
    }

    void FreshText()  ////függvény a score kiírásra
    {
        if (scoreText != null)
            scoreText.text = $"Score: {collectedValue}";
    }
}
