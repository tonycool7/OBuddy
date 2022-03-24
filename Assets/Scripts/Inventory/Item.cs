using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
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

    public Color GetColor()
    {
        switch (itemType)
        {
            default:

            case ItemType.Key:      return new Color(0, 0, 0);
            case ItemType.Ax:       return new Color(1, 0, 0);
            case ItemType.Basket:   return new Color(0, 0, 1);
            case ItemType.Pickaxe:  return new Color(1, 1, 0);
            case ItemType.Random:   return new Color(0, 1, 1);
        }


    }



}
