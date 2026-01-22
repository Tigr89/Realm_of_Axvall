using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject player;
   // public int playerlive;
    public GameObject Blade;
    
    //player
   // public int playerhealth = 6;
    // public List<Image> healthImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(bladeCoroutine());

    }

    // Update is called once per frame
    void Update()
    {

    }
   /* void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemyattack")
        {
            DamagePlayer(1);
        }
    }
   
    public void DamagePlayer(int dmg)
    {
        playerhealth -= dmg;
    }*/
    IEnumerator bladeCoroutine()
    {
        yield return new WaitForSeconds(5);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<player>().playerhealth -= 1;
            if (other.GetComponent<player>().playerhealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

