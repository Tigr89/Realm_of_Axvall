using UnityEngine;

public class EChase : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private GameObject player;
    






    void Start()
    {
    
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    
    }
}

