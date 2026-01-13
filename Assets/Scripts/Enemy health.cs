using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public int baseEnemyHealth;    
    public int enemyLevel;
    public int enemyHealth;
    void Start()
    {
        //int enemyHealth = baseEnemyHealth * enemyLevel; <-- Fixade koden genom att bara ta bort "int"! Vi skriver endast datatypen när vi deklarerar en variabel.
        //Annars tycker jag att idén var enkel och bra! Snygg lösning för att ge olika fiender olika hälsa.
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
            Destroy(gameObject);
        }
    }
}
