using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Creating a reference to the Rigidbody2D-component.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //This line of code handles movement
        rb.linearVelocity = moveSpeed * moveInput;

    }

    //This function returns a value between -1 and 1 in both X and Y-axis depending on player input
    public void Movement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    //This function stops player from moving out of 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mapCollider")
        {
            transform.position = new Vector2(-transform.position.x, 0);
        }
    }

}
