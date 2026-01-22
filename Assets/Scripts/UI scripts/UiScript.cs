using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiScript : MonoBehaviour
{

    [ Header("Player References")]
    public Invetorysystem playerInventory;
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
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        healthPotionText.text = "Health Potions: " + playerInventory.healthPotions;
        manaPotionText.text = "Mana Potions: " + playerInventory.manaPotions;
        playerHealthText.text = "HP: " + playerStats.Health;


        healthSlider.value = playerStats.Health;
        XPslider.value = playerStats.Experience;

        StrenghText.text = "Str: " + playerStats.Strengh;
        InteligenceText.text = "Int: " + playerStats.Inteligence;
        DexterityText.text = "Dex: " + playerStats.Dexterity;
        
    }
}
