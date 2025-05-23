using UnityEngine;

public class ResultAudioScript : MonoBehaviour
{
    public AudioSource audioSource; // 音源
    public AudioSource audioSourceClap;
    public AudioSource audioSourceclap2;

    void OnEnable() // このオブジェクトがアクティブになったときに呼ばれる
    {
        audioSource.Play(); // 音を再生
        audioSourceClap.Play();
        audioSourceclap2.Play();
    }
}
