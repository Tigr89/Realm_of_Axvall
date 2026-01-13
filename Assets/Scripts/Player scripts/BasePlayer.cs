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
   
    public void warriorlevelup()
    {
        health += 20;
        strengh += 5;
        inteligence += 2;
        dexterity += 3;
    }
    public void magelevelup()
    {
        health += 15;
        strengh += 3;
        inteligence += 5;
        dexterity += 2;
    }
    public void roguelevelup()
    {
        health += 10;
        strengh += 2;
        inteligence += 3;
        dexterity += 5;
    }
}


