using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMainMenu : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    public void OnclickBackMainMenuButotn()
    {
        audioSource.Play();
        SceneManager.LoadScene("StartScene");
    }
}
