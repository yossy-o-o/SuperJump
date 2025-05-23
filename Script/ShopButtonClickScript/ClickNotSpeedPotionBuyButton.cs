using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickNotSpeedPotionBuyButton : MonoBehaviour
{
    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource ClickSource;
    [SerializeField] GameObject SpeedPotionBuyPanel;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ClickClip;
    }
    public void OnClickNotSpeedPotionBuyButton()
    {
        ClickSource.Play();
        SpeedPotionBuyPanel.SetActive(false);
    }
}
