using UnityEngine;

public class playertest : BasePlayer
{
    public playertest(string _string)
    {
        if (_string == "WARRIOR")
        {
            CharacterClass = characterClass.WARRIOR;
            health = 100;
            strengh = 15;
            inteligence = 5;
            dexterity = 10;
            experience = 0;
        }
        else if (_string == "MAGE")
        {
            CharacterClass = characterClass.MAGE;
            health = 100;
            strengh = 10;
            inteligence = 15;
            dexterity = 5;
            experience = 0;
        }
        else if (_string == "ROGUE")
        {
            CharacterClass = characterClass.ROGUE;
            health = 100;
            strengh = 5;
            inteligence = 10;
            dexterity = 15;
            experience = 0;
        }
    }
}
