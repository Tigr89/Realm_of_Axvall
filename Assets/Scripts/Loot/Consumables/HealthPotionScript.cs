using UnityEngine;

public class HealthPotionScript : MonoBehaviour
{
   

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (InvetorySystem.healthPotions <= 4)
            {
                InvetorySystem.healthPotions += 1;
                Destroy(gameObject);
            }
        }
    }
}


