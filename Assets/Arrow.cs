using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Arrow : MonoBehaviour
{
    public float speed = 5f;
    public float damage = 10f;

    //public Vector3 targetPosition;
    public Vector2 direction;
    
    private void Start()
    {
        // Only update the target for the first click position
        
    }
    private void Update()
    {
        Move();
    }

    
    public void Move()
    {
        transform.position = speed * direction * Time.deltaTime;
    }
}
