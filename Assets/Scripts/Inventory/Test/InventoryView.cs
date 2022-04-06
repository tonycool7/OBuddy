using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryView : MonoBehaviour
{
    Inventory instance;

    private void Start()
    {
        instance = Inventory.instance;
        instance.OnItemAddedToInventory += AddItemToInventoryView;
        instance.OnItemRemovedFromInventory += RemoveItemFromInventoryView;
    }

    private void AddItemToInventoryView(object o, ItemAddedToInventory itemArg)
    {
        Item item = itemArg.item;
        print($"{item.name} added to inventory");
        RerenderInventory("add", item);
    }

    private void RemoveItemFromInventoryView(object o, ItemRemovedFromInventory itemArg)
    {
        Item item = itemArg.item;
        print($"{itemArg.item.name} removed from inventory");
        RerenderInventory("remove", item);
    }

    private void OnRemoveBtnClick(Item item)
    {
        instance.Remove(item);
    }

    private void RerenderInventory(string action, Item item)
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "InventorySlot")
            {
                Transform slot = child.GetChild(0);
                Transform itemSlot = slot.GetChild(0);
                Image icon = itemSlot.GetComponent<Image>();
                Button itemBtn = slot.GetComponent<Button>();
                Button removeBtn = child.GetChild(1).GetComponent<Button>();

                if (!icon.IsActive() && action == "add")
                {
                    icon.enabled = true;
                    icon.sprite = item.icon;
                    removeBtn.interactable = true;
                    itemBtn.onClick.AddListener(() => item.Use());
                    removeBtn.onClick.AddListener(() => OnRemoveBtnClick(item));
                    break;
                }
                else if (icon.sprite == item.icon && action == "remove")
                {
                    icon.enabled = false;
                    icon.sprite = null;
                    removeBtn.interactable = false;
                    itemBtn.onClick.RemoveAllListeners();
                    removeBtn.onClick.RemoveAllListeners();
                    break;
                }
            }
        }
    }
}
