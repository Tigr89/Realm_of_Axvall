using UnityEngine;

public class Invetorysystem : MonoBehaviour
{
    public int health_potions = 0;
    public int gold = 0;
    public bool has_weapon = false;
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
            health_potions += 1;
            Debug.Log("Health potions: " + health_potions);
        }
    }

    public void OTriggerEnter(Collider other)
    {
        Debug.Log("Health potions: " + health_potions);
    }
}
