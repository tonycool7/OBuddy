using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : AInteractables
{
    Inventory instance;
    public Item expectedItem;

    private void Start()
    {
        instance = Inventory.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interact();
    }

    public override void Interact()
    {
        if(instance != null)
        {
            String name = instance.selectedItem ? instance.selectedItem.name : "no item was selected";
            print(name);
            if (name == expectedItem.name)
            {
                transform.gameObject.SetActive(false);
                instance.Remove(instance.selectedItem);
            }
        }
    }
}
