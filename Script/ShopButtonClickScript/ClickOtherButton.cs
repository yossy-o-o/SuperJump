using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOtherButton : MonoBehaviour
{
    [SerializeField] GameObject speedUpPotionBuyPanel;
    [SerializeField] GameObject StopTimerItemBuypanel;
    [SerializeField] AudioSource ClickaudioSource;
    [SerializeField] AudioClip clickclip;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clickclip;
    }

    //SpeedUppotionを押したらStopTimerItemBuyPanelを消してSpeeduoPotionBuypanelを出す
    public void OnclickSpeedUpPotion()
    {
        ClickaudioSource.Play();
        speedUpPotionBuyPanel.SetActive(true);
        StopTimerItemBuypanel.SetActive(false);
    }

    //StopTimerItemを押したら
        public void OnclickStopTimerItem()
    {
        ClickaudioSource.Play();
        speedUpPotionBuyPanel.SetActive(false);
        StopTimerItemBuypanel.SetActive(true);
    }
}
