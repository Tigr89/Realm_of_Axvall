using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] Transform Target; 
    NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        var Target = GameObject.FindWithTag("target");
        agent.SetDestination(Target.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
       
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

    }
    /*
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "target")
        {
            agent.SetDestination(GameObject.FindWithTag("target2").transform.position);
        }
        else if(other.gameObject.tag == "target2")
        {
            agent.SetDestination(GameObject.FindWithTag("target").transform.position);
        }
    }
    */
}
