using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public enum ItemType
    {
        Coin,
        Key,
        weapon,
        Flask,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.weapon: return ItemAssets.Instance.weaponSprite;
            case ItemType.Coin: return ItemAssets.Instance.coinSprite;
            case ItemType.Flask: return ItemAssets.Instance.flaskSprite;
            case ItemType.Key: return ItemAssets.Instance.keySprite;
        }
    }
}
