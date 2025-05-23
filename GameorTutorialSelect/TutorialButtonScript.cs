using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButtonScript : MonoBehaviour
{
    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }

    public void OnclickTutorialButton()
    {
            clickaudioSource.Play();
            SceneManager.LoadScene("SelectTutorialStage");
    }
}
