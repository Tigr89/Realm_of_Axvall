using UnityEngine;

public class PlayerStats : PlayerBase
{ 

    [Header("Class Bools")]
    public bool isWarrior;
    public bool isMage;
    public bool isRogue;
    
    public string classString = "WARRIOR";
    public float experienceToNextLevel = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeClass();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            experience += 50;
        }

        if (experience >= experienceToNextLevel)
        {
            levelUp();
        }
        
    }
    public void changeClass()
    {
        chooseclass(classString);

        if (CharacterClass == rpgClass.WARRIOR)
        {
            isWarrior = true;
            isMage = false;
            isRogue = false;
            Debug.Log("Class set to WARRIOR");
        }
        else if (CharacterClass == rpgClass.MAGE)
        {
            isWarrior = false;
            isMage = true;
            isRogue = false;
            Debug.Log("Class set to MAGE");
        }
        else if (CharacterClass == rpgClass.ROGUE)
        {
            isWarrior = false;
            isMage = false;
            isRogue = true;
            Debug.Log("Class set to ROGUE");
        }
    }
    public void levelUp()
    { 
        experienceToNextLevel = experienceToNextLevel + experienceToNextLevel * 1.1f;

        if (isWarrior)
        {
            warriorlevelup();
            Debug.Log("Leveled up as WARRIOR");
        }
        else if (isMage)
        {   
            magelevelup();
            Debug.Log("Leveled up as MAGE");
        }
        else if (isRogue)
        {
            roguelevelup();
            Debug.Log("Leveled up as ROGUE");
        }
        
    }
    
}
