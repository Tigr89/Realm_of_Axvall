using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject Blade;
    public int dmg;
    
    public Animator animator;
    public float delay = 0.3f;
    private bool attackBlocked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(bladeCoroutine());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && attackBlocked == false)
        {
            Attack();
        }


    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
          //  other.GetComponent<enemy>.takedamage(dmg);
        }
    }
   
   
    IEnumerator bladeCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
    }
    void Calkdmg()
    {
        // damage calculator 
    }
    public void Attack()
    {
        if (attackBlocked) 
        return;
        animator.SetTrigger("Attack");
        attackBlocked = true;
        StartCoroutine(DelayAttack());
    }
    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
}

