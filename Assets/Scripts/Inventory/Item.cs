using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{

    public enum ItemType
    {
        Key,
        HealthPotion,
        Coin,
        BoxKit,
        SomethingIDontKnow,
    }

    public ItemType itemType;
    public int amount;

}
