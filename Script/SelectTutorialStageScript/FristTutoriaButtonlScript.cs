using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FristTutoriaButtonlScript : MonoBehaviour
{
    
    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;
    
    AudioSource audioSource;
    public void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }
    public void onClickFristTutorialButton()
    {
        clickaudioSource.Play();
        SceneManager.LoadScene("Tutorial1");
    }

    public void onClickSecondTutorialButton()
    {
        clickaudioSource.Play();
        SceneManager.LoadScene("Tutorial2");
    }
}
