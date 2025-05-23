using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialNextButtonScript : MonoBehaviour
{
    [SerializeField] GameObject TutorialPanel;
    [SerializeField] GameObject ClearTutorialPanel;
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    public void OnNextButtonClick()
    {
        audioSource.Stop();
        audioSource.Play();
        TutorialPanel.SetActive(true);
        ClearTutorialPanel.SetActive(false);
    }
}
