using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class StartButton : MonoBehaviour
{
    [SerializeField] Button SceneStartButton;
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = SceneStartButton.GetComponent<Button>(); 
        btn.onClick.AddListener(OnclickStartButton); 
        DontDestroyOnLoad(SceneStartButton.gameObject); // 一回表示されたらずっと表示
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
        audioSource.clip = audioClip; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnclickStartButton()
    {
        audioSource.Play();
        SceneManager.LoadScene("GameorTutorialSelect");
    }
}
