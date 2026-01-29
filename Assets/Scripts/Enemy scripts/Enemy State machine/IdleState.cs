using UnityEngine;

public class IdleState : State
{
    public ChaseState chaseState;
    public bool canSeeThePlayer;
    public override State RunCurrentState()
    {
        if (canSeeThePlayer)
        {
            canSeeThePlayer = false;
            return chaseState;
           
        }
        else
        {
            return this;
        }
    }
}
