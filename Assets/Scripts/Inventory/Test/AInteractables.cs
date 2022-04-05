using System;
using System.Collections;
using UnityEngine;

public class AInteractables : MonoBehaviour, IInteractables
{
    public float radius = 2f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    public virtual void Interact()
    {
        print("interacting");
    }
}
