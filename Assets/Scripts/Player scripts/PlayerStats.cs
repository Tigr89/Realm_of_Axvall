using UnityEngine;

public class PlayerStats : PlayerBase
{
    [Header("Attack script")]
    public GameObject attackScript;

    [Header("Class Bools")]
    private bool isWarrior; //Tobias ändrat till private för att inte förvirra de som jobbar med spelaren
    private bool isMage;
    private bool isRogue;

    [Header("DEBUG/TESTING")]
    public string classString = "WARRIOR"; //Kanske bör vara radioknappar som väljer klass istället för att användaren ska skriva in en string.
    public float experienceToNextLevel = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeClass();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            PlayerDie();
        }

        if (experience >= experienceToNextLevel)
        {
            levelUp();
        }

        if (Input.GetMouseButtonDown(0))
        {
            attackScript.GetComponent<AttacksClass>().SelectBasicAttack(classString);
        }
        if (Input.GetMouseButtonDown(1))
        {
            attackScript.GetComponent<AttacksClass>().SelectSpecialAttack(classString);
        }
        if (Input.GetMouseButtonDown(2))
        {
            attackScript.GetComponent<AttacksClass>().SelectUltimateAttack(classString);
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
