using UnityEngine;

public class Collectable : AInteractables
{
    public Item item;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    public override void Interact()
    {
        base.Interact();
        Pickup();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pickup();
    }

    void Pickup()
    {
        gameManager.UpdateFeedBack($"picking up {item.name}");
        AddToInventory();
    }

    void AddToInventory()
    {
        if (Inventory.instance.Add(item)) Destroy(gameObject);
    }
}
