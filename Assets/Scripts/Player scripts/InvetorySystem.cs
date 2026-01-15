using UnityEngine;

public class Invetorysystem : MonoBehaviour
{
    public int healthPotions = 0;
    public int gold = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Health potion")
        {
            healthPotions += 1;

        }
    }



    
}
