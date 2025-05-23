using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutoria1PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject ExplainPanel;
    [SerializeField] GameObject dekakabochaPanel;
    [SerializeField] AudioClip audioClip;
    
    AudioSource audioSource;
    void Start()
    {
        showDekakabochaPanel();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;

    }

    // Update is called once per frame
    void Update()
    {
        CloseExpandPanel();
    }


    
    public void showDekakabochaPanel()
    {
        dekakabochaPanel.SetActive(true);
    }

    //Tutorial1のEnter,Clickでpanelが閉じる処理
    public void CloseExpandPanel()
    {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            ExplainPanel.SetActive(false);       
        }
    }
}
