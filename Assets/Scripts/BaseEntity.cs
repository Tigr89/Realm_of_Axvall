using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    [Header("Stats")]
    public int health;

    public int strengh;
    public int inteligence;
    public int dexterity;

    public int experience;

    public enum rpgClass 
    {
        WARRIOR,
        MAGE,
        ROGUE, 
    }
    public enum enemyType
    {
        CHICKEN,
        SNAKE,
        ZOMBIE,
        DRAGON
    }

    public enum animDirection
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    
    public Vector2 movement;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Strengh
    {
        get { return strengh; }
        set { strengh = value; }
    }

    public int Inteligence
    {
        get { return inteligence; }
        set { inteligence = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public rpgClass CharacterClass
    {
        get;
        set;
    }
    
    public enemyType EnemyType
    {
        get;
        set;
    }

    public animDirection Direction
    {
        get;
        set;
    }
    public Vector2 Movement
    {
        get { return movement; }
        set { movement = value; }
    }
    public animDirection currentAnimDirection
    {
        get;
        set;
    }

    protected void TakeDamage(int damage)
    {
        health -= damage;
        // armor osv
    }
    protected void SetAnimDirection()
    {
        if (movement.y > 0)
        {
            currentAnimDirection = animDirection.UP;
        }
        else if (movement.y < 0)
        {
            currentAnimDirection = animDirection.DOWN;
        }
        else if (movement.x < 0)
        {
            currentAnimDirection = animDirection.LEFT;
        }
        else if (movement.x > 0)
        {
            currentAnimDirection = animDirection.RIGHT;
        }
    }
    
}


