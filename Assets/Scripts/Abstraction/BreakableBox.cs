using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour, IDamageable
{
    private void Start()
    {
        Damage(3);
    }
    public void Damage(int damage)
    {
        Debug.Log("Box Break");
    }
}
