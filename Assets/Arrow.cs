using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject sprite;
    public float projectileSpeed = 10f;
    public float lifetimeSeconds = 2f;
    
    Vector3 worldMousePos;
    Vector2 direction;

    void Start()
    {
        SetDir();
        Destroy(gameObject, lifetimeSeconds);
    }


    void Update()
    {
        
        if (direction != null)
        {
            rb.linearVelocity = direction * projectileSpeed;
        }
        else
        {
            rb.linearVelocity = Vector3.up * projectileSpeed;
        }
        
    }
    private void SetDir()
    {
        worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (Vector2)((worldMousePos - transform.position));
        direction.Normalize();

        sprite.transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
}
