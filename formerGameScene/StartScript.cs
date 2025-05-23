using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI startText;
    [SerializeField] GameObject StartPanel;
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
    void Update()
    {
        GameStart();
    }
    public void GameStart()
    {
        if(Input.GetKey(KeyCode.Return) || Input.GetMouseButton(0))
        {
            audioSource.Play();
            SceneManager.LoadScene("GameScene");
        }
    }
}
