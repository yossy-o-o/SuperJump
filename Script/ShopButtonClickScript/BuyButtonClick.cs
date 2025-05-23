using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyButtonClick : MonoBehaviour
{
      [SerializeField] GameObject itemSelectpanel;
      [SerializeField] Button otherButton;

      [SerializeField] GameObject HaveMoneyPanel;
      [SerializeField] GameObject ExplianPanel;
      [SerializeField] GameObject ItemExplainPanel;
      [SerializeField] AudioClip audioClip;

      AudioSource audioSource;
    void Start()
    { 
      //onClick.AddListenerでボタン押されたら実行されるイベント
      otherButton.onClick.AddListener(HidePanel);
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = audioClip;
    }

    public void onClicckBuyButton()
    {
      audioSource.Play();
      itemSelectpanel.SetActive(true);
      ExplianPanel.SetActive(false);
      ItemExplainPanel.SetActive(true);
    }

        void HidePanel()
    {
          itemSelectpanel.SetActive(false);
          ExplianPanel.SetActive(false);
    }

}
