using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : PlayerStats
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeClass();
        //Creating a reference to the Rigidbody2D-component.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TempMoveInput();
        //This line of code handles movement
        rb.linearVelocity = moveSpeed * moveInput * dexterity/10;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            levelUp();
            //experience += 50;
        }

        if (experience >= experienceToNextLevel)
        {
            levelUp();
        }
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
