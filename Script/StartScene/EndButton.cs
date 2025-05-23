using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    [SerializeField] GameObject EndPanel;
    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;

    public void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }

    public void OnclicEndButton()
    {
        EndPanel.SetActive(true);
        audioSource.Play(); 
    }
}

