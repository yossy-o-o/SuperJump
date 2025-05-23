using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アイテムのデータ
public class BaseItemData
{
    public string itemName;
    public int price;

    public string itemEffect;

    public Sprite Icon;
    
    public BaseItemData()
    {
        ItemEntity itemEntity = Resources.Load<ItemEntity>("ItemEntityList/CoinUpItem");
        itemName = itemEntity.name;
        price = itemEntity.price;
        itemEffect = itemEntity.itemEffect;
        Icon = itemEntity.Icon;
    }
}
