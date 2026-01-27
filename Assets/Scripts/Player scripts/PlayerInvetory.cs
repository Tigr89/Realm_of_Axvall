using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInvetory : MonoBehaviour 
{
    
    public PlayerStats playerStats;

    private float healthPotionCooldown = 0;
    

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {     
            if (InvetorySystem.healthPotions > 0 && Time.time > healthPotionCooldown && playerStats.Health < 100)
            {
                healthPotionCooldown = Time.time + 3;
                StartCoroutine(UseHealthPotion());
            }
        }
    }

    public IEnumerator UseHealthPotion()
    {

        InvetorySystem.healthPotions -= 1;
        playerStats.Health += 20;
        
       yield return null;
    }
}
