using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButtonClick : MonoBehaviour
{
    [SerializeField] List<GameObject> panels; // Inspectorで管理したいすべてのパネルをアサインしてください
    [SerializeField] Button endButton; // InspectorでENDボタンをアサインしてください
    [SerializeField] AudioClip audioclip;

    AudioSource audioSource;

    void Start()
    {
        // ボタンにクリックイベントを追加します
        endButton.onClick.AddListener(OnClickEndButton);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioclip;
    }

    // すべてのパネルを非表示にするメソッド
    void HideAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }

    // ENDボタンが押されたときに呼び出されるメソッド
    public void OnClickEndButton()
    {
        audioSource.Play();
        HideAllPanels();
    }
}