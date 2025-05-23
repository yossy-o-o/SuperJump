using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButtonClick : MonoBehaviour
{
    [SerializeField] GameObject itemListpanel;
    [SerializeField] GameObject speedUpPotion;
    [SerializeField] GameObject CoinUpItem;
    [SerializeField] GameObject itemExplainPanel;

    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }
    public void onClicckSelectItemButton()
    {
      clickaudioSource.Play();
      itemListpanel.SetActive(true);
      speedUpPotion.SetActive(true);
      CoinUpItem.SetActive(true);
      itemExplainPanel.SetActive(false);
    }
}
