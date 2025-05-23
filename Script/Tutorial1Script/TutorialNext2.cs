using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialNext2 : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioClip audioClip2;


    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    public void OnclickNext2Button()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        SceneManager.LoadScene("Tutorial2");
        Time.timeScale = 0;
    }

    //Tutorialをクリアした後のNextButton処理
    public void OnclickNext3Button()
    {
        audioSource.clip = audioClip2;
        audioSource.Play();
        SceneManager.LoadScene("formerGamescene");
    }
}