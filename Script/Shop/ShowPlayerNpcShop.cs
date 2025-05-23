using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowPlayerNpcShop : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] List<GameObject> closePanel;
    [SerializeField] GameObject ExplainPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            panel.SetActive(true);
            ExplainPanel.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "player") // プレイヤーとの接触が終了した場合
        {
            panel.SetActive(false); // パネルを非表示
            ExplainPanel.SetActive(false);
            AllClosePanel(); //全てのパネルを非表示
        }
    }

    void AllClosePanel()
    {
        foreach(var panel in closePanel)
        {
            panel.SetActive(false);
        }
    }
}