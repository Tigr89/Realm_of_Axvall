using UnityEngine;

public class ArrowRain : MonoBehaviour
{
    public float lifetimeSeconds = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetimeSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
