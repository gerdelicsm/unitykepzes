using UnityEngine;

class VampireMerchant : MonoBehaviour
{
    // Bemeneti változók:
    [SerializeField] int gold;   // Arany
    [SerializeField] int hp;     // Életpont

    // Kimeneti változók:
    [SerializeField] bool canBuyMace;   // Megvehetem-e a buzogányt
    [SerializeField] bool canBuyDagger; // Megvehetem-e a tõrt
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