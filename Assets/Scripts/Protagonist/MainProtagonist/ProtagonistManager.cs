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

    }

    void Update()
    {
       
    }
}
