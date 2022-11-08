using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color col; //csin�l egy color fel�letet komponensk�nt
    [SerializeField] float speed;

    bool toA=false;   // a fel� halad�st r�gz�ti

    void OnValidate()
    {
        transform.position = (a + b) / 2f;   /// j�t�kon k�v�l a �s b pont k�z�tti vektor f�l�tj�n legyen az object
    }

    void Update()   /// loopoljuk az ir�nyt
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

    // void OnDrawGizmosSelected() <<---- ez csak akkor jelen�ti meg a gizm�kat, ha ki vannak jel�lve
    void OnDrawGizmos() // kirajzolja gizmok�nt Editorban
    {
        Gizmos.DrawWireSphere(a, 0.2f); //seg�dg�mb kirajzol�d�s
        Gizmos.color = col;  ///behivatkozza a serializefieldet a sz�nnel a vonalhoz
        Gizmos.DrawWireSphere(b, 0.2f); // seg�dvonal kirajzol�d�s
        Gizmos.color = Color.blue; //seg�dg�mb sz�n�nek defini�l�sa
        Gizmos.DrawLine(a, b);
        Gizmos.color = new Color(0.5f,0,1,1); ///RGB-ben meghat�rozott saj�t sz�n, utols� az alpha csatorn�ja
    }
}
