using System.Collections;
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
/*
    //Hej Adam! Har slängt ihop en ganska enkel lösning för dig för hur du återgår till Idle från AttackState.
    //Så som det fungerar nu så bestämmer variabeln "attackDuration" hur länge attacken ska vara och sedan
    //går den tillbaka till IdleState. Kika igenom kommentarerna för att lära dig hur den fungerar!

    //Vi skapar en referens till IdleState och en variabel för vår attackDuration (som vi kan modifiera i inspektorn senare)
    public State IdleState;
    public float attackDuration = 2f;

    //Vi har en float som bestämmer tiden för hur länge attacken ska vara. 
    float timer;
    //Vi har en bool som kontrollerar när attacken börjar.
    bool entered;

    public override State RunCurrentState()
    {
        //Om entered är falsk så resettar vi vår timer och sätter entered till sann.
        if (entered == false)
        {
            timer = 0f;
            entered = true;
            Debug.Log("Is attacking!");
        }

        //Timern tickar upp varje frame.
        timer += Time.deltaTime;

        //När timern kommit ikapp vår attackDuration så blir entered falsk (vilket betyder att vi kan köra vår AttackState igen från början)
        //och NPCn återgår till IdleState.
        if (timer >= attackDuration)
        {
            entered = false;
            return IdleState;
        }

        //Fortsätter this (AttackState) tills timern tagit slut.
        return this;
    }*/
}
