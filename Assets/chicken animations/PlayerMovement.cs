using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float moveTimeMin = 1f;
    [SerializeField] private float moveTimeMax = 3f;
    [SerializeField] private float waitTimeMin = 0.5f;
    [SerializeField] private float waitTimeMax = 2f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        StartCoroutine(Wander());
    }

    void Update()
    {
        rb.linearVelocity = moveDirection * moveSpeed;
    }

    private IEnumerator Wander()
    {
        while (true)
        {
            // Pick one of four directions (no diagonals)
            int dir = Random.Range(0, 4);

            switch (dir)
            {
                case 0: moveDirection = Vector2.up; break;
                case 1: moveDirection = Vector2.down; break;
                case 2: moveDirection = Vector2.left; break;
                case 3: moveDirection = Vector2.right; break;
            }

            animator.SetBool("isWalking", true);
            animator.SetFloat("inputX", moveDirection.x);
            animator.SetFloat("inputY", moveDirection.y);

            float moveTime = Random.Range(moveTimeMin, moveTimeMax);
            yield return new WaitForSeconds(moveTime);

            // Stop moving
            animator.SetBool("isWalking", false);
            animator.SetFloat("lastinputX", moveDirection.x);
            animator.SetFloat("lastinputY", moveDirection.y);

            moveDirection = Vector2.zero;

            float waitTime = Random.Range(waitTimeMin, waitTimeMax);
            yield return new WaitForSeconds(waitTime);
        }
    }
}

