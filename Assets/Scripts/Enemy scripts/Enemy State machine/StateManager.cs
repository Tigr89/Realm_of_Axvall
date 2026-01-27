using UnityEngine;
using System.Collections;
public class StateManager : MonoBehaviour
{
  public State currentState;
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        RunStateMachine();

        if (currentState.GetType() == typeof(IdleState))
        {

            //Debug.Log("walking around");
        }

        if (currentState.GetType() == typeof(ChaseState))
        {
            
            //Debug.Log("Han jagar");
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 5 * Time.deltaTime);
        }

        if (currentState.GetType() == typeof(AttackState))
        {
            //if AttackState == false
            //if AttackState == true

            //attack
            //Debug.Log("I have Attacked");
            StartCoroutine(AttackTimer());

        }
    }
    IEnumerator AttackTimer()
    {
        yield return new WaitForSeconds(1);
    }
    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null)
        {
            SwitchToTheNextState(nextState);
        }
    }
    private void SwitchToTheNextState(State nextState)
    {
        currentState = nextState;
    }
}
