using UnityEngine;

class HelloWorld : MonoBehaviour
{//met�dus nagy bet�vel
    void Start()
    {
        //Ki�r�s Debug.Log-hoz k�pest
        Debug.Log("Hello World");
        Debug.Log("I'm" + name);
        /* �rdekes */

        //deklar�ci�
        int myFirstVariable;
        myFirstVariable = 56;
        myFirstVariable = 47;
        //defin�ci�

        int a, b, c;
        //operandusok

        //m�velet = oper�tor
        a = 3;
        b = 6;
        c = a + b;
        Debug.Log(c);
        c = 145;
        Debug.Log(c);

        //int csak eg�sz sz�mokkal, t�rtek nem m�k�dnek
        //int bemenettel a kimenet is mindig int - kerek�t
        //kimenet = "visszat�r�s"
        int d = a - b;
        int e = a * b;
        int f = a / b;
        Debug.Log(f);

        //float t�pus �rt�ke m�g� mindig kell egy "f"-et, ha t�rtr�l van sz�. Ponttal jel�lt a t�rt nem vessz�vel.
        float myFirstFloat = 2.67f;
        float mySecondFloat = 4;
        float ratio = myFirstFloat / mySecondFloat;
        Debug.Log(ratio);
        
        float fff = (float)a / b;
        Debug.Log(fff);

        //Casting = �trakjuk m�sik t�pusba. intn�l k�l�n be kell jel�lni
        float f1 = 1;
        int i1 = (int) 2.4f;
        Debug.Log(i1);

        //sz�veges t�pus
        string myFirstString = "Hello";
        string mySecondString = "World";

        string osszeadas = myFirstString + mySecondString;
        //string bemenetn�l a kimenet is string, ami nem �sszead�s, hanem �sszef�z�s

        string s1 = $"Hello World{i1}, {ratio}";

        int age = 35;
        float height = 1.78f;
        string nev = "Miki";

        //$-jel kell ahhoz, hogy stringk�nt m�k�dj�n �s lehivatkozza a t�bbit

        string introduction = $"My name is {nev}, I'm {height} m height, I'm {age} year old.";
        Debug.Log(introduction);

        //v�ltoz�k kis bet�vel
        //modulo oszt�s "%" jellel. Oszt�s, az eredm�ny a marad�k. int m = 7 % 3;   //1
        int m = 22 % 7;             //1
        float mf = 12.34f % 5;       //2,34f

        //bool t�pus� egy darab �rt�ket vehet fel - true/false

        bool bbb = true;
        bool bbb2 = false;

        bbb2 = true;
    }
}
