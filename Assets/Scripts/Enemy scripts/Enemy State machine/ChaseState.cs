using UnityEngine;

public class ChaseState : State
{

    public FOV fov;

    public AttackState attackState;
    public IdleState idleState;
    public bool isInAttackRange;
    [SerializeField] private float speed = 1.5f;
    private GameObject player;
    private GameObject enemy;

    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        fov = enemy.GetComponent<FOV>();
    }

    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            isInAttackRange = false;
            return attackState;
        }
        if(fov.CanseePlayer == false)
        {
            //fov.CanseePlayer = false;
            return idleState;
           
        }
        else
        {
            
            return this;
            
        }




    }
    


}
