using UnityEngine;

public class ArrowRain : MonoBehaviour
{
    public float lifetimeSeconds = 5f;
    public int damagePerSecond = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetimeSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void debugmsg()
    {
        Debug.Log($"Arrow Rain lifetime is {lifetimeSeconds} seconds");
        Debug.Log($"Arrow Rain does {damagePerSecond} damage per second");
    }
}
