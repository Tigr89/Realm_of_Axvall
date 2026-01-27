using UnityEngine;

public class ManaPotions : MonoBehaviour
{



    public InvetorySystem invetorysystem;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (invetorysystem.manaPotions <= 4)
            {
                invetorysystem.manaPotions += 1;
                Destroy(gameObject);
            }
        }
    }
}


