using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;


    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventory();

    }

    private void RefreshInventory()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 250f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTranform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTranform.gameObject.SetActive(true);
            itemSlotRectTranform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }

    }


}
