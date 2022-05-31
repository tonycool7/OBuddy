using System;
using System.Collections;
using UnityEngine;

public class AInteractables : MonoBehaviour, IInteractables
{
    public virtual void Interact()
    {
        print("interacting");
    }
}
