using UnityEngine;

public class EnemyBase : BaseEntity
{
    public EnemyBase()
    {
        health = 50;
        strengh = 5;
        inteligence = 0;
        dexterity = 0;
        //experience = 20; //kanske användas för att ge spelaren xp när fienden dödas
    }

    public void setEnemyType(string _string)
    {
        if (_string == "CHICKEN")
        {
            EnemyType = enemyType.CHICKEN;
            health = 10;
            strengh = 2;
            inteligence = 0;
            dexterity = 1;
            //experience = 20; //om det ska användas för att ge spelaren xp när fienden dödas
        }
        else if (_string == "SNAKE")
        {
            EnemyType = enemyType.SNAKE;
            health = 20;
            strengh = 4;
            inteligence = 0;
            dexterity = 3;
            //experience = 30; //om det ska användas för att ge spelaren xp när fienden dödas
        }
        else if (_string == "ZOMBIE")
        {
            EnemyType = enemyType.ZOMBIE;
            health = 40;
            strengh = 6;
            inteligence = 0;
            dexterity = 2;
            //experience = 50; //om det ska användas för att ge spelaren xp när fienden dödas
        }
        else if (_string == "DRAGON")
        {
            EnemyType = enemyType.DRAGON;
            health = 100;
            strengh = 15;
            inteligence = 5;
            dexterity = 5;
            //experience = 200; //om det ska användas för att ge spelaren xp när fienden dödas
        }
        else
        {
            Debug.Log("Invalid enemy type string. Defaulting to CHICKEN.");
            EnemyType = enemyType.CHICKEN;
            health = 10;
            strengh = 2;
            inteligence = 0;
            dexterity = 1;
            //experience = 20; //om det ska användas för att ge spelaren xp när fienden dödas
        }
    }
}
