using UnityEngine;
using TMPro;  /// ezzel be van hívva a TextMesh Pro
using System.Collections;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;  // public int behívható máshonnan
    [SerializeField] TMP_Text healthText;
    [SerializeField] Behaviour behaviour;
    [SerializeField] float invincibilityFrames = 1;

    //float invincibilityStarted;  ---> sebezhetetlenség kezdete
    bool isInvincible = false;
    int startHealth;
    // [SerializeField] Behaviour gameover;  // saját megoldásaim jegyzetben

    void Start()
    {
        //   gameover.enabled = false;  //saját megoldás
        startHealth = health;
        health = PlayerPrefs.GetInt("health", health);
        UpdateText();
    }

    public bool IsAlive()
    {
        return (health > 0);
    }
    /*
    void Update()
    {
        if (isInvincible)
        {

            if (Time.time > invincibilityFrames + invincibilityStarted)  //beállított idõ + kezdõ idõnél több
            {
                isInvincible = false;
            }
        }
    }
    */
    public void Damage(int damage)
    {
        if (isInvincible)
        {
            return;
        }
        health -= damage;  // health-bõl kivonódik a damage értékû hp
        PlayerPrefs.SetInt("health", health);
        //invincibilityStarted = Time.time;  //halhatatlanság ideje egyenlõ a jelen idõvel

        StartCoroutine(InvincibilityCoroutine()); //korutin meghívása

        if (health < 0)
            health = 0;

        if (health == 0)
        { behaviour.enabled = false;
            PlayerPrefs.SetInt("health", startHealth);

        }
        //            gameover.enabled = true;   //saját megoldás

        //    if (health >0)  //saját megoldás
        //        gameover.enabled = false;   //saját megoldás

        UpdateText();
    }
    IEnumerator InvincibilityCoroutine()  //korutint hoztunk létre az eltelt idõre
    {
        const float flickTime = 0.1f; //const kitétellel ez egy nem változó értékû változó. megadjuk a villódzás idõtartamát

        isInvincible = true;   //halhatatlan-e

        bool visible = false;

        for (int i = 0; i < invincibilityFrames / flickTime; i++)
        {
            SetVisibility(visible); // meghívja a setVisibility metódust
            visible = !visible;
            yield return new WaitForSeconds(flickTime); //"yield return" kifejezés --> enumerator esetén több visszatérés lehetséges. létrehozunk egy új idõ számlálót
        }

        SetVisibility(true); // visszavonja a láthatatlanságot
        isInvincible = false; //visszavonja a halhatatlanságot
    }
    void SetVisibility(bool isVisible) // metódust hozunk létre a villogásra
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>(); //lekérjük elemenként az object összes childjának mesh-eit

        foreach (var renderer in renderers)  //minden egyes mesh-re vonatkozóan ciklusként végigmegyünk
        {
            renderer.enabled = isVisible; //enable visibility-je kikapcsol
        }

    }
    void UpdateText()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;  /// mit írjon ki a textmesh
    }
}
