using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemEntity",menuName ="CreateItemEntity")]
//アイテムデータそのもの
public class ItemEntity : ScriptableObject
{
    public string itemName;
    public int price;

    public string itemEffect;

    public Sprite Icon;
}
