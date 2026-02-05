using UnityEngine;

public class Knifes : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject sprite;
    public float knifesProjectileSpeed = 10f;
    public float lifetimeSeconds = 2f;
    public int knifeDamage = 9;
    Vector3 worldMousePos;
    Vector2 direction;


    void Start()
    {
        SetDir();
        Destroy(gameObject, lifetimeSeconds);
        debugmsg();
    }


    void Update()
    {

        if (direction != null)
        {
            rb.linearVelocity = direction * knifesProjectileSpeed;
        }
        else
        {
            rb.linearVelocity = Vector3.up * knifesProjectileSpeed;
        }

    }
    private void SetDir()
    {
        worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (Vector2)((worldMousePos - transform.position));
        direction.Normalize();

        sprite.transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
    private void debugmsg()
    {
        Debug.Log($"I do {knifeDamage} damage");
        Debug.Log($"My direction is {direction}");
        Debug.Log($"My speed is {knifesProjectileSpeed}");
        Debug.Log($"My lifetime is {lifetimeSeconds}");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {

            other.GetComponent<EnemyStats>().health -= knifeDamage;
        }
    }
}
