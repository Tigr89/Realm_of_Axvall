using UnityEngine;

public class HealthPotionScript : MonoBehaviour
{
    public Invetorysystem invetorysystem;
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
            if (invetorysystem.healthPotions <= 4)
            {
                invetorysystem.healthPotions += 1;
                Destroy(gameObject);
            }
        }
    }
}
