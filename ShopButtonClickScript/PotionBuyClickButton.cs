using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UIElements;

//ポーションのPanelを押したときに出るObject
public class PotionBuyClickButton : MonoBehaviour
{
    [SerializeField] GameObject jumpUpPosion;
    [SerializeField] GameObject ShopNpc;
    [SerializeField] GameObject wagon;
    public float destroyTime;
    [SerializeField] public List<GameObject> closePanelList;
    [SerializeField] GameObject byebyePanel;
    [SerializeField] GameObject Box;

    [SerializeField] AudioClip Clickclip;
    [SerializeField] AudioSource ClickaudioSource;

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Clickclip;
    }

    public void OnPotionBuyClickButton()
    {
        ClickaudioSource.Play();
        jumpUpPosion.SetActive(true);
        Box.SetActive(true);
        Invoke("ShopNpcDestroy", destroyTime);//2回かえないようにするためにshopNpcをdestroyTimeで消す
        Invoke("ClosePanel", 0.5f);           //全部のPanelを消す
        Invoke("DestroyWagon", destroyTime);  //ShopNpcと同様に消す
    }

    void ShopNpcDestroy()
    {
        Destroy(GameObject.Find("ShopNpc"));
        byebyePanel.SetActive(false);
    }

    void DestroyWagon()
    {
        Destroy(wagon);
    }

    void ClosePanel()
    {
        foreach(var panel in closePanelList)
        {
            panel.SetActive(false);
        }
    }
}
