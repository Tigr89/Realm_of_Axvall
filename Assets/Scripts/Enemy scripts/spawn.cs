using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;


public class spawn : MonoBehaviour
{
    public GameObject enemy;
    public int spawnrate = 20;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(3.4f, -0.2f, 0);
        for (var i = 0; i < spawnrate; i++)
        {
            float startposx = Random.Range(-8.0f, 8.0f);
            float startposy = Random.Range(-8.0f, 8.0f);
            Instantiate(enemy, new Vector3(startposx, startposy, 0), Quaternion.identity);
           // stats.GetComponent<statisticsManager>().healthyCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnEnemy()
    {
        float SpawnX = player.transform.position.x + Random.Range(-4.0f, 4.0f);
        float SpawnY = player.transform.position.y + Random.Range(-4.0f, 4.0f);

        yield return new WaitForSeconds(2);
        Instantiate(enemy,new Vector3(SpawnX, SpawnY, 0),transform.rotation);
        yield return null;
       
    }
    public void startspawn()
    {
        StartCoroutine(SpawnEnemy());

    }

}


