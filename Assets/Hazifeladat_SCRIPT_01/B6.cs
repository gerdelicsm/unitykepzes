using UnityEngine;

class B6 : MonoBehaviour
{
    [SerializeField] int arany;
    [SerializeField] int HP;
    [SerializeField] bool buzoganyvasarlas;
    [SerializeField] bool torvasarlas;
    [SerializeField] bool vampirfogvasarlas;

    void OnValidate()
    {
        int buzogany = 10;
        int tor = 4;
        int vampirfog = 13;

        bool vampirfogvasarlas1 = arany > vampirfog ^ HP > vampirfog;
        bool buzoganyvasarlas1 = arany > buzogany ^ HP > buzogany;
        bool torvasarlas1 = arany > tor ^ HP > tor;

        if (torvasarlas1 == true)
            torvasarlas = true;
        else if (buzoganyvasarlas1 == true && torvasarlas1 == true)
        {
            buzoganyvasarlas = true;
            torvasarlas = true;
        }
        else if (vampirfogvasarlas1 == true && buzoganyvasarlas1 == true && torvasarlas1 == true)
        {
            buzoganyvasarlas = true;
            torvasarlas = true;
            vampirfogvasarlas = true;
        }
        else
        {
            vampirfogvasarlas = false;
            buzoganyvasarlas = false;
            torvasarlas = false;
        }
    }
}