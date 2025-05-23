using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButtonScript : MonoBehaviour
{

    [SerializeField] AudioClip ClickClip;
    [SerializeField] AudioSource clickaudioSource;

    AudioSource audioSource;

    // ここでformerGamesceneを定義します
    public string formerGamescene;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
      audioSource.clip = ClickClip;
    }
    public void OnclickContinueButton()
    {
        clickaudioSource.Play();
        StartCoroutine(GameRestart());
    }

    IEnumerator GameRestart()
    {
        Debug.Log("PushButton");

        // 2秒（実時間）待つ
        yield return new WaitForSecondsRealtime(1);

        // formerGamesceneをロードします
        SceneManager.LoadScene(formerGamescene);
        Time.timeScale = 1;
    }
}
