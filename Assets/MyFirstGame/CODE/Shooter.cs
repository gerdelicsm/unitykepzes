using System.Collections.Generic;
using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern  //saj�t kateg�ria l�trehoz�sa a benne l�v� fix t�pusok felsorol�s�val
    {
        Random, Sequence, Keyboard
    }

    [SerializeField] GameObject[] projectilePrototypes;  //a kil�tt l�ved�k
    [SerializeField] List<KeyCode> keys; // keyk�dok
    [SerializeField] float speed; //l�ved�k sebess�ge
    [SerializeField] ShootingPattern pattern;  //l�v�s mint�zat / v�ltoz�sa

    int count = 0;
    int bulletIndex = 0;

    void Update()
    {/*
        Collector ammo = GetComponent<Collector>();*/ //pr�b�lkoz�s saj�t k�d
        BulletSelect();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void BulletSelect()  // v�laszthat� l�ved�kt�pusok
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

    void Shoot()  //met�duss� alak�tott l�v�s 
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

        Vector3 direction = transform.forward; //transform ebben az esetben arra vonatkozik, amelyik gameobjectre r� van h�zva
        direction.Normalize();

        /*
        Vector3 v= transform.TransformVector(Vector3.up);  //fel ir�ny glob�lis koordin�t�n�l
        Vector3 v2= transform.InverseTransformVector(v);   //inverz ir�ny glob�lis koordin�t�n�l
        */
        rb.velocity = direction * speed;

        count++;
    }
}
