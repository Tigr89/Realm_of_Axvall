using UnityEngine;

public class BasePlayer
{
    public int health;

    public int strengh;
    public int inteligence;
    public int dexterity;

    public int experience;

    public enum characterClass
    {
        WARRIOR,
        MAGE,
        ROGUE
    }
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

    public characterClass CharacterClass
    {
        get;
        set;
    }

    
}


