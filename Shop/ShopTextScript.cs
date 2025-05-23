using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopTextScript : MonoBehaviour
{
    public TextMeshProUGUI displayText; // 表示するテキスト
    public GameObject textpanel;
    public Vector3 offset = new Vector3(0, 1, 0); // オブジェクトからのオフセット

    void Update()
    {
        // 自分自身の位置を取得
        Vector3 position = transform.position;
        // ワールド座標をスクリーン座標に変換
        Vector3 screenPos = Camera.main.WorldToScreenPoint(position + offset);
        // テキストの位置を更新
        displayText.transform.position = screenPos;
        panel();
    }

    void panel()
    {
        Vector3 position = transform.position;
        // ワールド座標をスクリーン座標に変換
        Vector3 screenPos = Camera.main.WorldToScreenPoint(position + offset);
        // テキストの位置を更新
        textpanel.transform.position = screenPos;
    }
}
