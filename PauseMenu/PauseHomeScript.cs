using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseHomeScript : MonoBehaviour
{
    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }

    // Update is called once per frame
    void Update()
    {
        // Invoke("OnclickPauseHomeButton", 2.0f); // この行を削除
    }

    public void OnclickPauseHomeButton()
    {
        clickaudioSource.Play();
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }
}
