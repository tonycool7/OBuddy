using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    private void Start()
    {
        Inventory.instance.OnItemAddedToInventory += AddItemToInventoryView;
        Inventory.instance.OnItemRemovedFromInventory += RemoveItemFromInventoryView;
    }

    private void AddItemToInventoryView(object o, ItemAddedToInventory itemArg)
    {
        Item item = itemArg.item;
        print($"{item.name} added to inventory");
        RerenderInventory("add", item);
    }

    private void RemoveItemFromInventoryView(object o, ItemRemovedFromInventory itemArg)
    {
        print($"{itemArg.item.name} removed from inventory");
    }

    private void RerenderInventory(string action, Item item)
    {
        switch(action)
        {
            case "add":
                foreach (Transform child in transform)
                {
                    if (child.gameObject.tag == "InventorySlot")
                    {
                        Image icon = child.GetChild(0).GetChild(0).GetComponent<Image>();
                        if (!icon.IsActive())
                        {
                            icon.enabled = true;
                            icon.sprite = item.icon; 
                            break;
                        }
                    }
                }
                break;
            case "remove":
                break;

            default:
                break;
        }

       

    }
}
