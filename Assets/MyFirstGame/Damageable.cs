using UnityEngine;
using TMPro;   /// ezzel be van hívva a TextMesh Pro

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;  // public int behívható máshonnan
    [SerializeField] TMP_Text healthText;
    [SerializeField] Behaviour behaviour;
   // [SerializeField] Behaviour gameover;  // saját megoldásaim jegyzetben

    void Start()
    {
   //   gameover.enabled = false;  //saját megoldás
        UpdateText();
    }

    public bool IsAlive()
    {
        return (health > 0);
    }

    public void Damage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;

        if (health == 0)
            behaviour.enabled = false;
//            gameover.enabled = true;   //saját megoldás

    //    if (health >0)  //saját megoldás
    //        gameover.enabled = false;   //saját megoldás

        UpdateText();
        }

    void UpdateText()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;  /// mit írjon ki a textmesh
    }
}
