using UnityEngine;

class Collectable : MonoBehaviour
{
   [SerializeField] Bounds bounds; ///létrehoz egy boundot
   public int value = 1; ///megadja hány pontot ér a coin

    public void TeleportRandom()
    {
        float randomX = Random.Range(bounds.min.x, bounds.max.x);  // megköti a bound kereteit
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(randomX, randomY, randomZ);  // létrehoz egy új random pozíciót
    }

    private void OnDrawGizmosSelected() //megrajzolja a boundot gizmoként
    {
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
