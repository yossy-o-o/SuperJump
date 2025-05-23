using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2PlayerScript1 : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    public void Update()
    {
        closeShopExplainPanel();
    }
    [SerializeField] GameObject shopExplainPanel;

    public void closeShopExplainPanel()
    {
        if(Input.GetKey(KeyCode.Return) || Input.GetMouseButton(0))
        {
            audioSource.Play();
            shopExplainPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
