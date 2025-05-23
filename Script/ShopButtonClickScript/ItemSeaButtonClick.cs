using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSeaButtonClick : MonoBehaviour
{
    [SerializeField] GameObject itemListpanel;
    [SerializeField] Button otherButton; // Inspectorで非表示にしたいボタンをアサインしてください
    [SerializeField] GameObject SpeedPotion;
    [SerializeField] GameObject TimedecreaseItem;

    void Start()
    {
        // ボタンにクリックイベントを追加します
        otherButton.onClick.AddListener(HidePanel);
        SpeedPotion.SetActive(true);
        TimedecreaseItem.SetActive(true);
    }

    public void onClicckItemSeaButton()
    {
        itemListpanel.SetActive(true);

    }

    // パネルを非表示にするメソッド
    void HidePanel()
    {
        itemListpanel.SetActive(false);
    }
}
