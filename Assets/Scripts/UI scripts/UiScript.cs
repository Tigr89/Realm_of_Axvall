using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiScript : MonoBehaviour
{
    public Invetorysystem playerInventory;
    public playertes playerStats;
    public TextMeshProUGUI playerHealthText;

    public TextMeshProUGUI healthPotionText;
    public TextMeshProUGUI manaPotionText;
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        healthPotionText.text = "Health Potions: " + playerInventory.healthPotions;
        manaPotionText.text = "Mana Potions: " + playerInventory.manaPotions;
        
    }
}
