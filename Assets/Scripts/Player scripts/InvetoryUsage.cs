using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class InvetoryUsage : MonoBehaviour
{
    public playertest playerStats;
    public Invetorysystem inventory;
    private float healthPotionCooldown;
    void Start()
    {
        inventory = GetComponent<Invetorysystem>();
        playerStats = GetComponent<playertest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
                  
            if (inventory.healthPotions > 0 && Time.time > healthPotionCooldown)
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
        
        return null;
    }
}
