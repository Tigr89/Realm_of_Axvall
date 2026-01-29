using UnityEngine;

public class ChaseState : State
{
    public AttackState attackState;
    public IdleState idleState;
    public bool isInAttackRange;
    [SerializeField] private float speed = 1.5f;
    private GameObject player;

    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            isInAttackRange = false;
            return attackState;
        }
        else 
        {
            return this;
        }


    }
    


}
