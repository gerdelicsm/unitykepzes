using UnityEngine;

class SerializeFieldPractice : MonoBehaviour
{
    [SerializeField] int age;
    [SerializeField] float height;
    [SerializeField] string myName;
    [SerializeField] bool smoking;
    [SerializeField] int number1, number2;
    [SerializeField] int sum;
    [SerializeField] int product;
    [SerializeField] float rate;
    [SerializeField] int difference;

    // metoduson kivul: osztaly valtozo (field)

    // atnevezes CTRL+RR !!! -----> ezzel a fajlt is atnevezi
    // CTRL K+D ----> automatikus beformázás

    // metodusok, Start --> lefut. Unity specifikus
    void Start()
    {
        int i = 4;
        Debug.Log(myName);
        // metoduson belul letrehozva : lokalis valtozo

        Debug.Log($"My name is {myName},I'm {age} years old.");
        Debug.Log($"I'm {height} m tall. Do I smoke? {smoking}");
    }
    void OnValidate()
    // metodusok, OnValidate ---> futtatason kivuli teszteleshez
    {
        Debug.Log("fffff");
        sum = number1 + number2;
        product = number1 * number2;
        rate = (float) number1 / number2;
        difference = number1 - number2;

        //SerializeField-ra hivatkozva mûveletek ---> kikerül a komponensbe
        
    }

}
