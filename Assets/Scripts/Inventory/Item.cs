using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{

    public enum ItemType
    {
        Key,
        Ax,
        Basket,
        Pickaxe,
        Random,
    }

    public ItemType itemType;
    public int amount;


    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:

            case ItemType.Key:      return ItemAssets.Instance.keySprite;
            case ItemType.Ax:       return ItemAssets.Instance.axSprite;
            case ItemType.Basket:   return ItemAssets.Instance.basketSprite;
            case ItemType.Pickaxe:  return ItemAssets.Instance.pickaxeSprite;
            case ItemType.Random:   return ItemAssets.Instance.randomeSprite;
        }
    }


}
