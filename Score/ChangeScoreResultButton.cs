using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScoreResultButton : MonoBehaviour
{
    [SerializeField] List<GameObject> ScorePanel;
    [SerializeField] GameObject MainResultPanel;

    [SerializeField] AudioClip clickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = clickClip;
      clickaudioSource.clip = clickClip;

        if (clickaudioSource == null)
        {
            Debug.Log("clickaudioSource is null");
        }
        if (clickClip == null)
        {
            Debug.Log("clickClip is null");
        }
    }
    public void OnclicckChangeScoreResultButton()
    {
        clickaudioSource.Play();
        MainResultPanel.SetActive(true);
        Allclose();
    }
    // Start is called before the first frame update
     void Allclose()
     {
        foreach(var panel in ScorePanel)
        {
            panel.SetActive(false);
        }
     }
}
