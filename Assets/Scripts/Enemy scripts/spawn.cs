using System.Collections;
using UnityEngine;


public class spawn : MonoBehaviour
{
    public GameObject enemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(3.4f, -0.2f, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnEnemy()
    {
        
        yield return new WaitForSeconds(2);
        Instantiate(enemy,new Vector3(3.4f, -0.2f, 0),transform.rotation);
        yield return null;

    }
    public void startspawn()
    {
        StartCoroutine(SpawnEnemy());

    }

}


