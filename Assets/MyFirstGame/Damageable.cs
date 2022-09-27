using UnityEngine;
using TMPro;   /// ezzel be van h�vva a TextMesh Pro

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;  // public int beh�vhat� m�shonnan
    [SerializeField] TMP_Text healthText;
    [SerializeField] Behaviour behaviour;
   // [SerializeField] Behaviour gameover;  // saj�t megold�saim jegyzetben

    void Start()
    {
   //   gameover.enabled = false;  //saj�t megold�s
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
//            gameover.enabled = true;   //saj�t megold�s

    //    if (health >0)  //saj�t megold�s
    //        gameover.enabled = false;   //saj�t megold�s

        UpdateText();
        }

    void UpdateText()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;  /// mit �rjon ki a textmesh
    }
}
