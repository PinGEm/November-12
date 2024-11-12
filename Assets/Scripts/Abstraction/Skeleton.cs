using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : NPCStats, IDamageable
{
    private void Start()
    {
        Movement();
        Attack();
        Damage(3); //input a value for damage
    }
    protected override void Movement()
    {
        Debug.Log("Skeleton moves");
    }

    protected override void Attack()
    {
        Debug.Log("Skeleton attack NPC");
    }
    public void Damage(int damage)
    {
        Debug.Log("Skeleton Health: " + health);
        health -= damage;
        Debug.Log("Skeleton HP After Hit: " + health);
    }
}
