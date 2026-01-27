using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInvetory : MonoBehaviour
{
    public PlayerStats playerStats;
    public InvetorySystem inventory;
    private float healthPotionCooldown = 0;
    

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {     
            if (inventory.healthPotions > 0 && Time.time > healthPotionCooldown && playerStats.Health < 100)
            {
                healthPotionCooldown = Time.time + 3;
                StartCoroutine(UseHealthPotion());
            }
        }
    }

    public IEnumerator UseHealthPotion()
    {

        inventory.healthPotions -= 1;
        playerStats.Health += 20;
        
       yield return null;
    }
}
