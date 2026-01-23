using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementHL : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private int dexterity = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Creating a reference to the Rigidbody2D-component.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dexterity = GetComponent<PlayerBase>().dexterity;
        TempMoveInput();
        rb.linearVelocity = moveSpeed * moveInput * dexterity / 10;
        //This line of code handles movement
        //rb.linearVelocity = moveSpeed * moveInput;

    }

    //This function returns a value between -1 and 1 in both X and Y-axis depending on player input
    public void Movement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    void TempMoveInput()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
}
