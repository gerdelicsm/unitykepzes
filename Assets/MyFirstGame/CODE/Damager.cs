using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage;

    void OnTriggerEnter(Collider other)  /// bármilyen other object amivel ütközik
    {
        Debug.Log("Hit: "+other.name);

        Damageable damageable = other.GetComponent<Damageable>();   //behív egy másik komponenset
        
        if (damageable!=null)
        {
            /// damageable.health--; /// nem behívható, mert a health érték a másik komponensben nem lettek publicra állítva. ami nem public, az private
            damageable.Damage(damage);
        }
    }
}
