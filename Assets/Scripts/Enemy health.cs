using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public int baseEnemyHealth;    
    public int enemyLevel;
    public int enemyHealth;
    void Start()
    {
        int enemyHealth = baseEnemyHealth * enemyLevel;
    }

   
    void Update()
    {
        
    }

    public void TakingDamage(int damageTaken)
    {
        enemyHealth -= damageTaken;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
