using UnityEngine;

public class test : MonoBehaviour
{
    public playertest player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = new playertest();
        printshit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void printshit()
    {
        Debug.Log(player.health);
        Debug.Log(player.strengh);
        Debug.Log(player.inteligence);
        Debug.Log(player.dexterity);
        Debug.Log(player.experience);
    }
}
