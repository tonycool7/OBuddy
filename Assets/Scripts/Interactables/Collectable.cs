using UnityEngine;

public class Collectable : AInteractables
{
    public Item item;

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
        print($"picking up {item.name}");
        AddToInventory();
    }

    void AddToInventory()
    {
        if (Inventory.instance.Add(item)) Destroy(gameObject);
    }
}
