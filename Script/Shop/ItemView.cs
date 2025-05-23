using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI itemName;
    [SerializeField] TextMeshProUGUI itemEffect;
    [SerializeField] TextMeshProUGUI price;
    [SerializeField] Image iconImage;

    public void Show(BaseItemData baseItemData)
    {
        itemName.text = baseItemData.itemName;
        itemEffect.text = baseItemData.itemEffect;
        price.text = baseItemData.price.ToString();
        iconImage.sprite = baseItemData.Icon;
    }
}
