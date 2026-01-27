using UnityEngine;

public class ManaPotions : MonoBehaviour
{




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
            if (InvetorySystem.manaPotions <= 4)
            {
                InvetorySystem.manaPotions += 1;
                Destroy(gameObject);
            }
        }
    }
}


