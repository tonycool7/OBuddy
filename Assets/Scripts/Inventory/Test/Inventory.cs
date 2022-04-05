using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemAddedToInventory : EventArgs 
{
    public Item item;
    public ItemAddedToInventory(Item it)
    {
        item = it;
    }
}
public class ItemRemovedFromInventory : EventArgs {
    public Item item;
    public ItemRemovedFromInventory(Item it)
    {
        item = it;
    }
}

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public int spaceSlots = 5;
    public event EventHandler<ItemAddedToInventory> OnItemAddedToInventory = (sender, args) => { };
    public event EventHandler<ItemRemovedFromInventory> OnItemRemovedFromInventory = (sender, args) => { };

    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Inventory has more tha none instance");
            return;
        }

        instance = this;
    }
    #endregion

    public bool Add(Item item)
    {
        if (item.isDefaultItem && items.Count > spaceSlots)
        {
            print("Inventory is full");
            return false;
        }

        items.Add(item);
        // Invoke the event only when a class / method is subscribed to it
        OnItemAddedToInventory?.Invoke(this, new ItemAddedToInventory(item));
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }
}