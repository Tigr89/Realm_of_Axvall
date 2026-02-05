using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementHL : PlayerStats
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    public Animator animator;
    public bool isMoving;
    //private int dexterity = 10;

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
        Movement = moveInput;
        SetAnimDirection();
        if (rb.linearVelocity != Vector2.zero)
        {
            isMoving = true;
            animator.SetBool("isWalking", true);
        }
        else
        {
            isMoving = false;
            animator.SetBool("isWalking", false);
            Movement = Vector2.zero;
        }
        //This line of code handles movement
        //rb.linearVelocity = moveSpeed * moveInput;
        if (currentAnimDirection == animDirection.UP)
        {
            animator.SetFloat("inputY", Movement.y);
        }
        if (currentAnimDirection == animDirection.DOWN)
        {
            animator.SetFloat("inputY", Movement.y);
        }
        if (currentAnimDirection == animDirection.LEFT)
        {
            animator.SetFloat("inputX", Movement.x);
        }
        if (currentAnimDirection == animDirection.RIGHT)
        {
            animator.SetFloat("inputX", Movement.x);
        }
        if (currentAnimDirection == animDirection.ZERO)
        {
            animator.SetFloat("inputX", 0);
            animator.SetFloat("inputY", 0);
        }
    }

    //This function returns a value between -1 and 1 in both X and Y-axis depending on player input
    public void MovementInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    void TempMoveInput()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
}
