using UnityEngine;

class HelloWorld : MonoBehaviour
{//metódus nagy betûvel
    void Start()
    {
        //Kiírás Debug.Log-hoz képest
        Debug.Log("Hello World");
        Debug.Log("I'm" + name);
        /* érdekes */

        //deklaráció
        int myFirstVariable;
        myFirstVariable = 56;
        myFirstVariable = 47;
        //definíció

        int a, b, c;
        //operandusok

        //mûvelet = operátor
        a = 3;
        b = 6;
        c = a + b;
        Debug.Log(c);
        c = 145;
        Debug.Log(c);

        //int csak egész számokkal, törtek nem mûködnek
        //int bemenettel a kimenet is mindig int - kerekít
        //kimenet = "visszatérés"
        int d = a - b;
        int e = a * b;
        int f = a / b;
        Debug.Log(f);

        //float típus értéke mögé mindig kell egy "f"-et, ha törtrõl van szó. Ponttal jelölt a tört nem vesszõvel.
        float myFirstFloat = 2.67f;
        float mySecondFloat = 4;
        float ratio = myFirstFloat / mySecondFloat;
        Debug.Log(ratio);
        
        float fff = (float)a / b;
        Debug.Log(fff);

        //Casting = átrakjuk másik típusba. intnél külön be kell jelölni
        float f1 = 1;
        int i1 = (int) 2.4f;
        Debug.Log(i1);

        //szöveges típus
        string myFirstString = "Hello";
        string mySecondString = "World";

        string osszeadas = myFirstString + mySecondString;
        //string bemenetnél a kimenet is string, ami nem összeadás, hanem összefûzés

        string s1 = $"Hello World{i1}, {ratio}";

        int age = 35;
        float height = 1.78f;
        string nev = "Miki";

        //$-jel kell ahhoz, hogy stringként mûködjön és lehivatkozza a többit

        string introduction = $"My name is {nev}, I'm {height} m height, I'm {age} year old.";
        Debug.Log(introduction);

        //változók kis betûvel
        //modulo osztás "%" jellel. Osztás, az eredmény a maradék. int m = 7 % 3;   //1
        int m = 22 % 7;             //1
        float mf = 12.34f % 5;       //2,34f

        //bool típusú egy darab értéket vehet fel - true/false

        bool bbb = true;
        bool bbb2 = false;

        bbb2 = true;
    }
}
