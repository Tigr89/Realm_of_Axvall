using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int baseEnemyHealth;
    public int enemyLevel;
    public int enemyHealth;

    private Animator animator;
    private PlayerMovement movement;
    private bool isDead = false;

    void Start()
    {
        enemyHealth = baseEnemyHealth * enemyLevel;
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        // PRESS K TO KILL ENEMY
        if (Input.GetKeyDown(KeyCode.K))
        {
            KillInstant();
        }
    }

    public void TakingDamage(int damageTaken)
    {
        if (isDead) return;

        enemyHealth -= damageTaken;

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    private void KillInstant()
    {
        if (isDead) return;
        enemyHealth = 0;
        Die();
    }

    private void Die()
    {
        isDead = true;

        // Stop movement
        if (movement != null)
            movement.enabled = false;

        // Trigger death animation
        animator.SetTrigger("IsDead");

        // Destroy AFTER animation (adjust time to match your animation length)
        Destroy(gameObject, 1.2f);
    }
}

