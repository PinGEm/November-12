using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chest : Interaction
{
    public override void Interacted() //override is used to change the functionality/implementation of a parent method/function
    {
        base.Interacted();
        if (isInteracted)
        {
            // Play closing chest animation
        }
        else
        {
            // Play opening chest animation
            DropLoot();
        }
    }

    public void DropLoot()
    {
        Debug.Log("Drop loots");
        DisplayToolTips(); 
    }
}
