using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistManager : MonoBehaviour
{
    public ProtagonistController Controller;
    public ProtagonistModel Model;
    public ProtagonistView View;

    private Inventory inventory;

    [SerializeField] private UIInventory uIInventory;

    private void Awake()
    {
        Controller = new ProtagonistController(Model, View);

        inventory = new Inventory();
        uIInventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(100, -80), new Item { itemType = Item.ItemType.Ax, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(180, 0), new Item { itemType = Item.ItemType.Basket, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0, -20), new Item { itemType = Item.ItemType.Pickaxe, amount = 1 });


    }

    void Update()
    {
       
    }
}
