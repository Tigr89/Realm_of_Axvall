using UnityEngine;

public class PlayerBase : BaseEntity
{
    
    public PlayerBase()
    {
        health = 100;
        strengh = 5;
        inteligence = 5;
        dexterity = 5;
        experience = 0;
        
    }
    public void chooseclass(string _string)
    {
        if (_string == "WARRIOR")
        {
            CharacterClass = rpgClass.WARRIOR;
            health = 100;
            strengh = 15;
            inteligence = 5;
            dexterity = 10;
            experience = 0;
        }
        else if (_string == "MAGE")
        {
            CharacterClass = rpgClass.MAGE;
            health = 100;
            strengh = 10;
            inteligence = 15;
            dexterity = 5;
            experience = 0;
        }
        else if (_string == "ROGUE")
        {
            CharacterClass = rpgClass.ROGUE;
            health = 100;
            strengh = 5;
            inteligence = 10;
            dexterity = 15;
            experience = 0;
        }
        else
        {
            Debug.Log("Invalid class string. Defaulting to WARRIOR.");
            CharacterClass = rpgClass.WARRIOR;
            health = 100;
            strengh = 15;
            inteligence = 5;
            dexterity = 10;
            experience = 0;
        }
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

    protected void PlayerDie()
    {
                Debug.Log("Player has died.");
        // Additional logic for player death can be added here
        // For example, triggering a game over screen or respawning

    }

}
