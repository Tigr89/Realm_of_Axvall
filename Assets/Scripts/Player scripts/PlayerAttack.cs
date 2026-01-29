using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using System;
using UnityEditor.Experimental.GraphView;


public class PlayerAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject Blade;
    public GameObject bladeParent;
    
    public int dmg;
    [SerializeField] private float bladeDistance = 1.5f;

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
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Vector3 direction = mousePos - bladeParent.transform.position;
        // Debug.Log(direction);
        bladeParent.transform.rotation = Quaternion.Euler(new Vector3(0, 0, MathF.Atan2(direction.y, direction.x) * Mathf.Rad2Deg));
        float angle = MathF.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bladeParent.transform.position = transform.position + Quaternion.Euler(0, 0, angle) * new Vector3(bladeDistance, 0 ,0);

        

        if (Input.GetKeyDown(KeyCode.Mouse0) && attackBlocked == false)
        {
            Attack();
        }




      /*  if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("Side Attack");
        }*/
        else
        {
          //  animator.SetTrigger("");
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
        Blade.GetComponent<BoxCollider2D>().enabled = true;
        animator.SetTrigger("Attack");
        attackBlocked = true;
        StartCoroutine(endColl());
        StartCoroutine(DelayAttack());
    }
    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
    private IEnumerator endColl()
    {
        yield return new WaitForSeconds(0.3f);
         Blade.GetComponent<BoxCollider2D>().enabled = false;
    }
}

