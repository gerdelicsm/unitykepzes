using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color col; //csinál egy color felületet komponensként
    [SerializeField] float speed;

    bool toA=false;   // a felé haladást rögzíti

    void OnValidate()
    {
        transform.position = (a + b) / 2f;   /// játékon kívül a és b pont közötti vektor félútján legyen az object
    }

    void Update()   /// loopoljuk az irányt
    {
        Vector3 target;
        if (toA)
            target = a;
        else
            target = b;

        transform.position = Vector3.MoveTowards(transform.position,target,speed * Time.deltaTime);

        if (toA)
            target = a;
        else
            target = b;
        if (target == transform.position)
        { 
            toA = !toA; 
        }
    }

    // void OnDrawGizmosSelected() <<---- ez csak akkor jeleníti meg a gizmókat, ha ki vannak jelölve
    void OnDrawGizmos() // kirajzolja gizmoként Editorban
    {
        Gizmos.DrawWireSphere(a, 0.2f); //segédgömb kirajzolódás
        Gizmos.color = col;  ///behivatkozza a serializefieldet a színnel a vonalhoz
        Gizmos.DrawWireSphere(b, 0.2f); // segédvonal kirajzolódás
        Gizmos.color = Color.blue; //segédgömb színének definiálása
        Gizmos.DrawLine(a, b);
        Gizmos.color = new Color(0.5f,0,1,1); ///RGB-ben meghatározott saját szín, utolsó az alpha csatornája
    }
}
