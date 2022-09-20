using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void OnValidate()
    {
        Vector2 vector = new Vector2(2, 5); //konstruktor függvények - vektor létrehozása (x,y koordináta) "new"

        float vx = vector.x;
        float vy = vector.y;

        vector.x = vy;
        vector.y = vx; // "." operátor ---> ha egy objektum több értéket tartalmaz, ezzel mehetünk lejjebbi információra

        Vector3 vector3 = new Vector3(1, 2, 4);
        vector3.z *= 2;

        Vector3 myUP = Vector3.up; //y tengelyen pozitív (0,1,0)
        Vector3 myLeft = Vector3.left; //x tengelyen negatív (-1,0,0)

        Vector3 v1 = new Vector3(1, 6, 4), v2 = new Vector3(3, 7, 8);
        Vector3 v3 = new Vector3(); //<<<---- alapból nulla értékekkel rendelkezik
        float f1 = 3;

        Vector3 vSum = v1 + v2; // (4,13,12)
        Vector3 vSum2 = v1 + v3;

        Vector3 vProduct = v1 * f1; //(3,18,12)

        float m = vProduct.magnitude; //vektor hosszának a lekérdezése ".magnitude"

        Vector3 n= v1.normalized;  //normalizálása a vektornak (szöget megtartva a hossza 1 lesz)
        v1.Normalize(); // függvényként ugyanaz, de nem ad vissza a végén semmit

        float distance = (v1 - v2).magnitude;  //v1 és v2 vektorok távolsága
        float distance2 = Vector3.Distance(v1, v2); // v1 és v2 vektorok távolsága szintén, csak függvénnyel

    }
}
