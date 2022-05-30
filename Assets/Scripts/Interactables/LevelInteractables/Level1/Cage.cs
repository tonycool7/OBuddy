using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : AInteractables
{
    Inventory instance;

    private void Start()
    {
        instance = Inventory.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interact();
    }
}
