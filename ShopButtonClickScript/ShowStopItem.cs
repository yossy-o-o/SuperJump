using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowStopItem : MonoBehaviour
{
    [SerializeField] GameObject stopTimerItem;
    [SerializeField] GameObject shopNpc; // この行は変更なし
    [SerializeField] GameObject wagon;
    public float destroyTime;
    [SerializeField] List<GameObject> closePanel;
    [SerializeField] GameObject byebyePanel;
    [SerializeField] GameObject Box;
    [SerializeField] AudioClip ClickaudioClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ClickaudioClip;
    }

    public void OnclickStopItemBuyButton()
    {
        clickaudioSource.Play();
        stopTimerItem.SetActive(true);
        Box.SetActive(true);
        Invoke("CloseAllPanel", 0.5f);
        Invoke("ShopNpcDestroy", destroyTime);
        Invoke("DestroyWagon", destroyTime);
    }

    void ShopNpcDestroy()
    {
        // GameObject.Find の代わりに直接 shopNpc を参照
        Destroy(shopNpc);
        byebyePanel.SetActive(false);
    }

    void DestroyWagon()
    {
        Destroy(wagon);
        Debug.Log("DestroyWagon");
    }
    void CloseAllPanel()
    {
        foreach(var panel in closePanel)
        {
            panel.SetActive(false);
        }
    }
}
