using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseScript : MonoBehaviour
{
    [SerializeField] List<GameObject> Pausepanel;
    [SerializeField] GameObject SoundContorllerPanel;
    private bool isPaused = false; // boolを使ってPauseMenu中か判断

    void Start()
    {
        
    }

    void Update()
    {
        OnclickPauseKey();
    }

    private void OnclickPauseKey()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SoundContorllerPanel.SetActive(false);   
            isPaused = !isPaused; // 状態を切り替える
            foreach(GameObject panel in Pausepanel)
            {
                panel.SetActive(isPaused); // 状態に応じてパネルを表示/非表示にする
            }
            Time.timeScale = isPaused ? 0 : 1; // isPausedがtrueの時はTimeScaleを0、falseの時は1になって再開する
        }
    }
}
