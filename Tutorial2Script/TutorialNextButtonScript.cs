using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialNextButtonScript : MonoBehaviour
{
    [SerializeField] GameObject shopExplainPanel;
    [SerializeField] GameObject ExplainPanel;
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    public void OnclickNextButton()
    {
        audioSource.Play();
        shopExplainPanel.SetActive(true);
        ExplainPanel.SetActive(false);
    }
}
