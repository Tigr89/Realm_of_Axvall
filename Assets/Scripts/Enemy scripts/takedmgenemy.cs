using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class takedmgenemy: MonoBehaviour
{
    public int enemylive = 1;
    public GameObject enemy;
    public GameObject spawn;
   // public GameObject enemyattack;
    //  public GameObject boss;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //Kalla på din coroutine här
      //  StartCoroutine(EnemyAttack());
      spawn = GameObject.Find("spawn");
        

    }


    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
            enemylive -= 1;
            if (enemylive <= 0)
            {
                spawn.GetComponent<spawn>().startspawn();
                Destroy(gameObject);

               // SceneManager.LoadScene("Level 2");
            }
        }
    }

   /* IEnumerator EnemyAttack()
    {

        while (enemyattack != null)
        {
            enemyattack.SetActive(true);
            yield return new WaitForSeconds(1);
            enemyattack.SetActive(false);
            yield return new WaitForSeconds(2);

        }
        yield return null;



        //Du vill ha en timer för fiendens attack
        //när fienden attackerar, aktivera ett objekt som är enemyattack
        //låt attacken vara aktiv i någon sekund med WaitForSeconds..
        //stäng av objektet
        //Loopa koden.
    }
   */
}
