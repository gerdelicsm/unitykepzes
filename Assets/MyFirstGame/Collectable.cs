using UnityEngine;

class Collectable : MonoBehaviour
{
   [SerializeField] Bounds bounds; ///l�trehoz egy boundot
   public int value = 1; ///megadja h�ny pontot �r a coin

    public void TeleportRandom()
    {
        float randomX = Random.Range(bounds.min.x, bounds.max.x);  // megk�ti a bound kereteit
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(randomX, randomY, randomZ);  // l�trehoz egy �j random poz�ci�t
    }

    private void OnDrawGizmosSelected() //megrajzolja a boundot gizmok�nt
    {
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
