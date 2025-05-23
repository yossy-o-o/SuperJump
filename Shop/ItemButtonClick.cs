using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemButtonClick : MonoBehaviour
{
    [SerializeField] private ItemEntity myData; // 作成したScriptableObjectをアタッチ
    [SerializeField] private TextMeshProUGUI itemname;
    [SerializeField] private TextMeshProUGUI itemeffect;
    [SerializeField] private TextMeshProUGUI Price;
    [SerializeField] private Image iconImage; // Imageコンポーネントをアタッチ
    [SerializeField] public GameObject BuyPanel;
    

    public void OnButtonClick()
    {
        itemname.text = myData.itemName;
        itemeffect.text = myData.itemEffect;
        Price.text = myData.price.ToString();
        iconImage.sprite = myData.Icon; // Imageコンポーネントのspriteプロパティに代入

        BuyPanel.SetActive(true);
    }

}
