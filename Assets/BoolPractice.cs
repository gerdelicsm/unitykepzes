
using UnityEngine;

 class BoolPractice : MonoBehaviour
{
    void Start()
    {
        bool b1 = true;
        bool b2 = false;
        Debug.Log(b2);
        b1 = false;
        Debug.Log(b2);

        int i1 = 3, i2 = 7;

        bool b3 = i1 > i2;
        Debug.Log("i1 > i2: " +b3); //false

        //nagyobb vagy egyenlo
        i1 = 7;
        Debug.Log("i1>=12:" + (i1 >= i2)); //false

        bool b4 = i1 < i2;      //true
        bool b5 = i1 <= i2;     //true

        //egyenloseg vizsgalat
        bool b6 = i1 == 6;
        Debug.Log(b6);          //false
        bool b7 = i2 != 7;      //false

        string s1 = "kave";

        bool b8 = s1 == "tea";      //false
        Debug.Log(b8);
        bool b9 = s1 != "tea";      //true

        bool b10 = b4 == b9;        //false

        //ket bool bemenet szinten bool kimenettel = ÉS mûvelet (operátora "&&")

        // Logikai muveletek
        //AND

        bool b11 = b1 && b2;                //false
        Debug.Log("AND PARANCS" +b11);

        //OR
        //vagy parancs operátora "||"

        bool b12 = b1 || b2;                //false
        Debug.Log("OR PARANCS" + b12);

        //XOR
        // bool b4=a^b; <----- kizaro vagy, operátora "^"

        bool b13 = b1 ^ b2;
        Debug.Log("XOR PARANCS" + b13);

        //NOT
        // egy bool-on végrehajtott tagado parancs, operatora: "!"
        bool b14 = !b1;

    }
}
