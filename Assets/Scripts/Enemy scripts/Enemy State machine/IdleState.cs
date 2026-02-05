using UnityEngine;

public class IdleState : State
{
    public FOV fov;
    
    public ChaseState chaseState;
    public bool canSeeThePlayer;
    public override State RunCurrentState()
    {
        /*
        if (canSeeThePlayer)
        {
            canSeeThePlayer = false;
            return chaseState;
           
        }
        else
        {
            return this;
        }
        */
        
        if(fov.CanseePlayer == true)
        {
            //fov.CanseePlayer = false;
            return chaseState;
           
        }
        else
        {
            
            return this;
            
        }
        

    }
}
