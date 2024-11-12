using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interaction
{
    public override void Interacted() //override is used to change the functionality/implementation of a parent method/function
    {
        base.Interacted();
        if (isInteracted)
        {
            // Move a platform
            // Change tooltip details
            isInteracted = false;
            DisplayToolTips();
        }
        else
        {
            // Move a platform
            // Change tooltip details
            isInteracted = true;
            DisplayToolTips();
        }
    }
}
