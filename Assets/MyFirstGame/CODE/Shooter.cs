using System.Collections.Generic;
using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern  //saját kategória létrehozása a benne lévõ fix típusok felsorolásával
    {
        Random, Sequence, Keyboard
    }

    [SerializeField] GameObject[] projectilePrototypes;  //a kilõtt lövedék
    [SerializeField] List<KeyCode> keys; // keykódok
    [SerializeField] float speed; //lövedék sebessége
    [SerializeField] ShootingPattern pattern;  //lövés mintázat / változása

    int count = 0;
    int bulletIndex = 0;

    void Update()
    {/*
        Collector ammo = GetComponent<Collector>();*/ //próbálkozás saját kód
        BulletSelect();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void BulletSelect()  // választható lövedéktípusok
    {
        for (int i = 0; i < keys.Count; i++)
        {
            KeyCode kc = keys[i];
                if(Input.GetKeyDown(kc))
            {
                bulletIndex = i;
            }
        }
    }

    void Shoot()  //metódussá alakított lövés 
    {
        GameObject proto;

        if (pattern == ShootingPattern.Random)
        {
            int randomNum = Random.Range(0, projectilePrototypes.Length);
            proto = projectilePrototypes[randomNum];
        }
        else if (pattern==ShootingPattern.Sequence)
        {
            int index = count % projectilePrototypes.Length;
            proto = projectilePrototypes[index];
        }
        else
        {
            int safeIndex = Mathf.Clamp(bulletIndex, 0, projectilePrototypes.Length - 1);
            proto = projectilePrototypes[safeIndex];
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
