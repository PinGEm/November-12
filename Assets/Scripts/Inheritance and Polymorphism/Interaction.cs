using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] protected string toolTips;
    [SerializeField] protected bool isInteracted;

    //public makes it so that any class can access the code
    //protected makes it so that any class INHERITING the script can access the code.

    protected void DisplayToolTips()
    {
        Debug.Log("Tool Tips: " + toolTips);
    }

    public virtual void Interacted() // virtual allows a CHILD to override the function, in this case the function Interacted() can be overriden by any class that inherits it.
    {
        if (isInteracted)
        {
            isInteracted = false;
        }
        else
        {
            isInteracted = true;
        }
    }
}
