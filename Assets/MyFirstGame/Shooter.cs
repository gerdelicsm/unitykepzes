using UnityEngine;

class Shooter : MonoBehaviour
{
    enum ShootingPattern  //saj�t kateg�ria l�trehoz�sa a benne l�v� fix t�pusok felsorol�s�val
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
        Collector ammo = GetComponent<Collector>();*/ //pr�b�lkoz�s saj�t k�d

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
}
