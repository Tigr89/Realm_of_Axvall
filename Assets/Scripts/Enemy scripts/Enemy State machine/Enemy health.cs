using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public int baseEnemyHealth;    
    public int enemyLevel;
    public int enemyHealth;
    void Start()
    {
        TakingDamage(1);
        enemyHealth = baseEnemyHealth * enemyLevel;
    }

   
    void Update()
    {
        
    }

    public void TakingDamage(int damageTaken)
    {
        enemyHealth -= damageTaken;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject, 1.2f);
        }
    }
}

