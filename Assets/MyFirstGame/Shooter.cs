using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern  //saját kategória létrehozása a benne lévõ fix típusok felsorolásával
    {
        Random, Sequence, Keyboard
    }

    [SerializeField] GameObject[] projectilePrototypes;
    [SerializeField] KeyCode[] keys;
    [SerializeField] float speed;
    [SerializeField] ShootingPattern pattern;

    int count = 0;

    void Update()
    {/*
        Collector ammo = GetComponent<Collector>();*/ //próbálkozás saját kód

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject proto;

            if (pattern == ShootingPattern.Random)
            {
                int randomNum = Random.Range(0, projectilePrototypes.Length);
                proto = projectilePrototypes[randomNum];
            }
            else
            {
                int index = count % projectilePrototypes.Length;
                proto = projectilePrototypes[index];
            }

            GameObject projectile = Instantiate(proto);

            projectile.transform.position = transform.position;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            Vector3 direction = transform.forward; //transform ebben az esetben arra vonatkozik, amelyik gameobjectre rá van húzva
            direction.Normalize();

            /*
            Vector3 v= transform.TransformVector(Vector3.up);  //fel irány globális koordinátánál
            Vector3 v2= transform.InverseTransformVector(v);   //inverz irány globális koordinátánál
            */
            rb.velocity = direction * speed;

            count++;
        }
    }
}
