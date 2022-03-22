using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{

    private List<Item> itemList;

    public Inventory()

    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Key, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Ax, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Pickaxe, amount = 1 });

        Debug.Log(itemList.Count);

        Debug.Log("Inventory");
    }


    public void AddItem (Item item)

    {
        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}