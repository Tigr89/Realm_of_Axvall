using System.Collections;


using UnityEngine;


using System;
using UnityEngine.SceneManagement;



public class FOV : MonoBehaviour
{
    public float radius = 10;
    [Range(1,360)]public float angel = 90; 
    
    public LayerMask TargetLayer;
    public LayerMask ObstructionLayer;

    public GameObject Player;
    public Rigidbody2D Playerrb;
   


    public bool CanseePlayer{get; private set;}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("target");
        
       
        //StartCoroutine (FOVcheck());
    }
    private void Awake()
    {
        Playerrb = GameObject.Find("target").GetComponent<Rigidbody2D>();
        
    }


    /*private IEnumerator FOVcheck()
    {
        WaitForSeconds paus = new WaitForSeconds(0.2f);
        while(true)
        {
            yield return paus;
            Fov();
        }
    }
*/
  
    private void Fov()
    {
        Collider2D[] rangecheck = Physics2D.OverlapCircleAll(transform.position, radius, TargetLayer);
        if (rangecheck.Length > 0)
        {
            Transform target = rangecheck[0].transform;
            Vector2 diractiontoTarget = (target.position - transform.position).normalized;
            if(Vector2.Angle(transform.up, diractiontoTarget)< angel/2 )
            {
                float DistanctoTarget = Vector2.Distance(transform.position, target.position);
                if(!Physics2D.Raycast(transform.position, diractiontoTarget, DistanctoTarget, ObstructionLayer))
                {
                    CanseePlayer = true;
                    Debug.Log(CanseePlayer);
                }
                else
                {
                    CanseePlayer = false;
                    
                }
            }
        
            else if(CanseePlayer)
            {
                CanseePlayer = false;
            
            }

        }
        else if(CanseePlayer)
        {
            CanseePlayer = false;
            
        }
    }

    private void OnDrawGizmos()
    {
        
        UnityEditor.Handles.DrawWireDisc(transform.position,Vector3.forward,radius);
        Gizmos.color = Color.red;
        Vector3 angle1 = DirectionFromAngle(-transform.eulerAngles.z,-angel/2);
        Vector3 angle2 = DirectionFromAngle(-transform.eulerAngles.z,angel/2);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + angle1 * radius);
        Gizmos.DrawLine(transform.position, transform.position + angle2 * radius);


    }
    private Vector2 DirectionFromAngle(float eulerY , float angleInDegrees)
    {
        angleInDegrees+= eulerY;
        return new Vector2(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    public void Update()
    {
        Debug.Log(CanseePlayer);
        if(Playerrb != null)
        {
    
        }
    
    }
    private IEnumerator paus()
    {
        while(true)
        {
            
            WaitForSeconds Paus = new WaitForSeconds(1f);
            yield return Paus;
            Destroy(Player);
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 0;
            if(Input.GetKey(KeyCode.Backspace))
            {
                Time.timeScale = 1;
            }
            
            
    

    
            //Application.Quit(0);
            
            yield return null;  
        }
        
    }
    
    
    
}
