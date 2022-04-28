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

    private Item _selectedItem;

    public Item selectedItem { get { return _selectedItem; } set { _selectedItem = value; } }

    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Inventory has more tha one instance");
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

    public bool Remove(Item item)
    {
        items.Remove(item);
        // Invoke the event only when a class / method is subscribed to it
        OnItemRemovedFromInventory?.Invoke(this, new ItemRemovedFromInventory(item));
        return true;
    }
}
