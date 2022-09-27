using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage;

    void OnTriggerEnter(Collider other)  /// b�rmilyen other object amivel �tk�zik
    {
        Debug.Log("Hit: "+other.name);

        Damageable damageable = other.GetComponent<Damageable>();   //beh�v egy m�sik komponenset
        
        if (damageable!=null)
        {
            /// damageable.health--; /// nem beh�vhat�, mert a health �rt�k a m�sik komponensben nem lettek publicra �ll�tva. ami nem public, az private
            damageable.Damage(damage);
        }
    }
}
