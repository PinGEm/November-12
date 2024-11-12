using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour // cannot create objects in a class with abstract keyword
{
    [SerializeField] protected string npcName;
    [SerializeField] protected int level;
    [SerializeField] protected float speed;
    [SerializeField] protected int health;
    [SerializeField] protected int armor;
    [SerializeField] protected int damage;

    protected abstract void Movement(); // not necesarry to add {}, because it is defined by the inherited classes.
    protected abstract void Attack();
}
