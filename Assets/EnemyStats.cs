using UnityEngine;

public class EnemyStats : EnemyBase
{

    [Header("Type Bools")]
    public bool isChicken;
    public bool isSnake;
    public bool isZombie;
    public bool isDragon;


    [Header("DEBUG/TESTING")]
    public string typeString = "CHICKEN";

    //public int debugDamage;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeType();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            EnemyDie();
        }
    }
    public void changeType()
    {
        SetEnemyType(typeString);

        if (EnemyType == enemyType.CHICKEN)
        {
            isChicken = true;
            isSnake = false;
            isZombie = false;
            isDragon = false;
            Debug.Log("Type set to CHICKEN");
        }
        else if (EnemyType == enemyType.SNAKE)
        {
            isChicken = false;
            isSnake = true;
            isZombie = false;
            isDragon = false;
            Debug.Log("Type set to SNAKE");
        }
        else if (EnemyType == enemyType.ZOMBIE)
        {
            isChicken = false;
            isSnake = false;
            isZombie = true;
            isDragon = false;
            Debug.Log("Type set to ZOMBIE");
        }
        else if (EnemyType == enemyType.DRAGON)
        {
            isChicken = false;
            isSnake = false;
            isZombie = false;
            isDragon = true;
            Debug.Log("Type set to DRAGON");
        }
    }

}
