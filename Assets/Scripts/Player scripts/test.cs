using System;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class test : MonoBehaviour
{

    public playertest player;
    [Header("Player Stats")]
    public int hp;
    public int str;
    public int intel;
    public int dex;
    
    public int experience;

    [Header("Class Bools")]
    public bool isWarrior;
    public bool isMage;
    public bool isRogue;
    
    public string classString = "WARRIOR";
    private float experienceToNextLevel = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = new playertest(classString);
        hp = player.health;
        str = player.strengh;
        intel = player.inteligence;
        dex = player.dexterity;
        experience = player.experience;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            experience += 99;
        }
        

        if (player.CharacterClass == BasePlayer.characterClass.WARRIOR)
        {
            isWarrior = true;
            isMage = false;
            isRogue = false;
            
        }
        else if (player.CharacterClass == BasePlayer.characterClass.MAGE)
        {
            isWarrior = false;
            isMage = true;
            isRogue = false;
        }
        else if (player.CharacterClass == BasePlayer.characterClass.ROGUE)
        {
            isWarrior = false;
            isMage = false;
            isRogue = true;
        }
        changeClass();

        if (player.experience >= experienceToNextLevel)
        {
            levelUp();
        }
    }
    void changeClass()
    {
        player = new playertest(classString);
        hp = player.health;
        str = player.strengh;
        intel = player.inteligence;
        dex = player.dexterity;
    }
    void levelUp()
    { 
        experienceToNextLevel = experienceToNextLevel + experienceToNextLevel * 1.1f;

        if (isWarrior)
        {
            player.warriorlevelup();
        }
        else if (isMage)
        {
            player.magelevelup();
        }
        else if (isRogue)
        {
            player.roguelevelup();
        }
        
    }
}
