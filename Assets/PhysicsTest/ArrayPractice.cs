using System.Collections.Generic;
using UnityEngine;

class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] intArrayField;
    [SerializeField] string[] stringArrayField;
    [SerializeField] Transform[] transformArrayField;
    [SerializeField] GameObject[] gameObjectArrayField;

    [SerializeField] List<int> intList;
    [SerializeField] List<string> stringList;
    [SerializeField] List<Transform> transformList;
    [SerializeField] List<GameObject> gameObjectList;

    void Start()
    {
        int[] arrayOfInts = new int[5];  /// tömb létrehozása ; 5 elemû tömb

        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            arrayOfInts[i] = i + 1;

            //            int element = arrayOfInts[i];
            //          Debug.Log(element);
        }
        int summa = 0;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            int element = arrayOfInts[i];
            summa += arrayOfInts[i];
        }
        ////        /\ a kettõ teljesen megegyezik, de a foreach egyszerûbb \/
        foreach (int element in arrayOfInts)  //elejétõl haladva a foreach minden elemen végrehajt valamit
        {
            summa += element;
        }
        Debug.Log(summa);
    }
    /*
    Transform[] transforms = new Transform[6];
    Transform[] transforms2 = FindObjectOfType<Transform>();
    Transform[] transforms3 = GetComponentsInChildren<Transform>();
    Transform[] transforms4 = GetComponentsInParents<Transform>();
    */
    string[] stringArray = { "AAA", "BBB", "CCC" };
    //stringArray[1]="DDD";

    // LISTÁK -----------------------------------
    List<int> _intList = new List<int>();
    void OnValidate()
    {
        for (int i = 0; i < 10; i++)
        {
            _intList.Add(i + 1);
            _intList.RemoveAt(3);
            _intList.Remove(1);
        }


        int _summa = 0;
        for (int i = 0; i < _intList.Count; i++)
        {
            _summa += _intList[i];
            Debug.Log(_summa);
        }

        List<string> stringList = new List<string>();
        stringList.Add("XXXX");
        stringList.Add("YYY");
        stringList.Add("ZZ");

        bool _contains = stringList.Contains("YYY");

        if (_contains)
            Debug.Log("CONTAINS");
        else
            Debug.Log("NOT CONTAINS");

        _intList.Clear();
            for (int i = 0; i < 25; i++)
        {
            _intList.Add(Random.Range(0, 101));
        }
        _intList.Sort();
    }
}

