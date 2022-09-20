using UnityEngine;

class VampireMerchant : MonoBehaviour
{
    // Bemeneti v�ltoz�k:
    [SerializeField] int gold;   // Arany
    [SerializeField] int hp;     // �letpont

    // Kimeneti v�ltoz�k:
    [SerializeField] bool canBuyMace;   // Megvehetem-e a buzog�nyt
    [SerializeField] bool canBuyDagger; // Megvehetem-e a t�rt
    [SerializeField] bool canBuyTeeth;  // Megvehetem-e a fogat

    void OnValidate()
    {
        int goldToHpRate = 5;

        // Mace
        int price = 10;
        canBuyMace = price <= gold || price * goldToHpRate < hp;

        // Dagger
        price = 4;
        canBuyDagger = price <= gold || price * goldToHpRate < hp;

        // Teeth
        price = 13;
        canBuyTeeth = price <= gold || price * goldToHpRate < hp;
    }
}