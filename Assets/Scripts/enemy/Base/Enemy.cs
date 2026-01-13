using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
     
{
    private Vector2 target;
    private Vector2 position;
    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private Vector3 GetRoamingPosition()
    {
        Vector3 ReturnPosition = Vector3.zero;

        //Slumpa ny position
        float Targetx = Random.Range(-4, +4);
        float Targety = Random.Range(-4, +4);

        ReturnPosition = new Vector3(Targetx, Targety, 0);

        


        return ReturnPosition;
    }
    private void Update()
    {
        //transform.position means the one with the script's position
        //next assignment I will work with making the enemy actually move in x area
    }

}
