using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartButtonScript : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
        audioSource.clip = audioClip; 
    }
    public void OnclickGameStartButton()
    {
        audioSource.Play();
        SceneManager.LoadScene("formerGamescene");
    }
}
