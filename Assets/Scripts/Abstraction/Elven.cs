using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elven : NPCStats
{
    private void Start()
    {
        Movement();
        Attack();
    }
    protected override void Movement()
    { 
        Debug.Log("Elven moves");
    }

    protected override void Attack()
    {
        Debug.Log("Elven attacks enemy!");
    }
}
