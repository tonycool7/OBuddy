using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryView : MonoBehaviour
{
    Inventory instance;
    public Image myItem;
    public Image cancelItem;

    private void Start()
    {
        instance = Inventory.instance;
        instance.OnItemAddedToInventory += AddItemToInventoryView;
        instance.OnItemRemovedFromInventory += RemoveItemFromInventoryView;
        Button cancelItemBtn = cancelItem.GetComponent<Button>();

        cancelItemBtn.onClick.AddListener(() => removeSelectedItem());
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

                if (!icon.IsActive() && action == "add")
                {
                    icon.enabled = true;
                    icon.sprite = item.icon;
                    itemBtn.onClick.AddListener(() => this.UseItem(item));
                    break;
                }
                else if (icon.sprite == item.icon && action == "remove")
                {
                    icon.enabled = false;
                    icon.sprite = null;
                    itemBtn.onClick.RemoveAllListeners();

                    if (myItem.sprite != null && myItem.sprite == item.icon)
                    {
                        removeSelectedItem();
                    }
                    break;
                }
            }
        }
    }

    private void removeSelectedItem()
    {
        cancelItem.enabled = false;
        myItem.sprite = null;
        myItem.enabled = false;
        instance.selectedItem = null;
    }

    private void UseItem(Item item)
    {
        instance.selectedItem = item;
        myItem.sprite = item.icon;
        myItem.enabled = true;
        cancelItem.enabled = true;
    }
}
