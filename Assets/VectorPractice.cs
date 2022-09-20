using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void OnValidate()
    {
        Vector2 vector = new Vector2(2, 5); //konstruktor f�ggv�nyek - vektor l�trehoz�sa (x,y koordin�ta) "new"

        float vx = vector.x;
        float vy = vector.y;

        vector.x = vy;
        vector.y = vx; // "." oper�tor ---> ha egy objektum t�bb �rt�ket tartalmaz, ezzel mehet�nk lejjebbi inform�ci�ra

        Vector3 vector3 = new Vector3(1, 2, 4);
        vector3.z *= 2;

        Vector3 myUP = Vector3.up; //y tengelyen pozit�v (0,1,0)
        Vector3 myLeft = Vector3.left; //x tengelyen negat�v (-1,0,0)

        Vector3 v1 = new Vector3(1, 6, 4), v2 = new Vector3(3, 7, 8);
        Vector3 v3 = new Vector3(); //<<<---- alapb�l nulla �rt�kekkel rendelkezik
        float f1 = 3;

        Vector3 vSum = v1 + v2; // (4,13,12)
        Vector3 vSum2 = v1 + v3;

        Vector3 vProduct = v1 * f1; //(3,18,12)

        float m = vProduct.magnitude; //vektor hossz�nak a lek�rdez�se ".magnitude"

        Vector3 n= v1.normalized;  //normaliz�l�sa a vektornak (sz�get megtartva a hossza 1 lesz)
        v1.Normalize(); // f�ggv�nyk�nt ugyanaz, de nem ad vissza a v�g�n semmit

        float distance = (v1 - v2).magnitude;  //v1 �s v2 vektorok t�vols�ga
        float distance2 = Vector3.Distance(v1, v2); // v1 �s v2 vektorok t�vols�ga szint�n, csak f�ggv�nnyel

    }
}
