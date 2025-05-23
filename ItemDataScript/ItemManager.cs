using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    ItemView View;
    BaseItemData ItemData;

    private void Awake()
    {
        View = GetComponent<ItemView>();
    }
    public void Init()
    {
        //ItemDataでBaseItemDataのすべてを管理する
        ItemData = new BaseItemData();
        View.Show(ItemData);
    }
        public void ShowItem()
    {
        // ボタンがクリックされたときに呼ばれるメソッド
        View.Show(ItemData);
    }
}
