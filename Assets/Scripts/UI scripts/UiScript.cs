using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiScript : MonoBehaviour
{

    [ Header("Player References")]
    public PlayerStats playerStats;


    [ Header("UI References")]
    public TextMeshProUGUI playerHealthText;
    public TextMeshProUGUI healthPotionText;
    public TextMeshProUGUI manaPotionText;
    public TextMeshProUGUI xpText;
    public TextMeshProUGUI StrenghText;
    public TextMeshProUGUI InteligenceText;
    public TextMeshProUGUI DexterityText;

    [ Header ("sliders")]
    public Slider healthSlider;
    public Slider manaSlider;
    public Slider XPslider;
    void Awake()
    {
        //kalla på funktionen om HiddenInventory inte är null
    }

    //Skapa en funktion som lagrar InventorySystem från HiddenInventory

    // Update is called once per frame
    void Update()
    {
        healthPotionText.text = "Health Potions: " + InvetorySystem.healthPotions;
        manaPotionText.text = "Mana Potions: " + InvetorySystem.manaPotions;
        playerHealthText.text = "HP: " + playerStats.Health;


        healthSlider.value = playerStats.Health;
        XPslider.value = playerStats.Experience;

        StrenghText.text = "Str: " + playerStats.Strengh;
        InteligenceText.text = "Int: " + playerStats.Inteligence;
        DexterityText.text = "Dex: " + playerStats.Dexterity;
        
    }
}
