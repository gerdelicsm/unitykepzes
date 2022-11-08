using UnityEngine;
using TMPro;  /// ezzel be van h�vva a TextMesh Pro
using System.Collections;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int health;  // public int beh�vhat� m�shonnan
    [SerializeField] TMP_Text healthText;
    [SerializeField] Behaviour behaviour;
    [SerializeField] float invincibilityFrames = 1;

    //float invincibilityStarted;  ---> sebezhetetlens�g kezdete
    bool isInvincible = false;
    int startHealth;
    // [SerializeField] Behaviour gameover;  // saj�t megold�saim jegyzetben

    void Start()
    {
        //   gameover.enabled = false;  //saj�t megold�s
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

            if (Time.time > invincibilityFrames + invincibilityStarted)  //be�ll�tott id� + kezd� id�n�l t�bb
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
        health -= damage;  // health-b�l kivon�dik a damage �rt�k� hp
        PlayerPrefs.SetInt("health", health);
        //invincibilityStarted = Time.time;  //halhatatlans�g ideje egyenl� a jelen id�vel

        StartCoroutine(InvincibilityCoroutine()); //korutin megh�v�sa

        if (health < 0)
            health = 0;

        if (health == 0)
        { behaviour.enabled = false;
            PlayerPrefs.SetInt("health", startHealth);

        }
        //            gameover.enabled = true;   //saj�t megold�s

        //    if (health >0)  //saj�t megold�s
        //        gameover.enabled = false;   //saj�t megold�s

        UpdateText();
    }
    IEnumerator InvincibilityCoroutine()  //korutint hoztunk l�tre az eltelt id�re
    {
        const float flickTime = 0.1f; //const kit�tellel ez egy nem v�ltoz� �rt�k� v�ltoz�. megadjuk a vill�dz�s id�tartam�t

        isInvincible = true;   //halhatatlan-e

        bool visible = false;

        for (int i = 0; i < invincibilityFrames / flickTime; i++)
        {
            SetVisibility(visible); // megh�vja a setVisibility met�dust
            visible = !visible;
            yield return new WaitForSeconds(flickTime); //"yield return" kifejez�s --> enumerator eset�n t�bb visszat�r�s lehets�ges. l�trehozunk egy �j id� sz�ml�l�t
        }

        SetVisibility(true); // visszavonja a l�thatatlans�got
        isInvincible = false; //visszavonja a halhatatlans�got
    }
    void SetVisibility(bool isVisible) // met�dust hozunk l�tre a villog�sra
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>(); //lek�rj�k elemenk�nt az object �sszes childj�nak mesh-eit

        foreach (var renderer in renderers)  //minden egyes mesh-re vonatkoz�an ciklusk�nt v�gigmegy�nk
        {
            renderer.enabled = isVisible; //enable visibility-je kikapcsol
        }

    }
    void UpdateText()
    {
        if (healthText != null)
            healthText.text = "Health: " + health;  /// mit �rjon ki a textmesh
    }
}
