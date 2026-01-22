using UnityEngine;

public class AttackState : State
{
    public bool isInAttackRange;
    public ChaseState chaseState;
    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
           
            return this;
        }
        else
        {
            return chaseState;
        }
    }
}
