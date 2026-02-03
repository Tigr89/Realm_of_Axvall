using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    //script referenses
    public FOV fov;
    private StateManager states;

    Transform snapShotPosition;

    [SerializeField] Transform Target; 
    NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        var Target = GameObject.FindWithTag("target");
        agent.SetDestination(transform.position);
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        fov = enemy.GetComponent<FOV>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(fov.CanseePlayer == true)
        {
            agent.SetDestination(Target.transform.position);
        //agent.isStopped = false;
        
        }
        else if(fov.CanseePlayer == false)
        {
            if(Target != null)
            {
                if(snapShotPosition.position != Target.transform.position)
                {
                    snapShotPosition.position = Target.transform.position;
                }
            }
            
            agent.SetDestination(snapShotPosition.position);
            //agent.isStopped = true;
        }
        
    }
    


       
        /*
        if(agent.destination != GameObject.FindWithTag("target2").transform.position)
        {
            agent.SetDestination(GameObject.FindWithTag("target").transform.position);
        }
        
        else if(agent.destination != GameObject.FindWithTag("target").transform.position)
        {
            agent.SetDestination(GameObject.FindWithTag("target2").transform.position);
        }
        */


    /*
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "target")
        {
            
            agent.isStopped = true;
            Debug.Log(agent.isStopped + "Stoppad");
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "target")
        {
            agent.isStopped = false;
            Debug.Log(agent.isStopped + "not Stoppad");
        }

    }
    */
}
