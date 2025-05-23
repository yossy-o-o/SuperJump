using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseContinueScript : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;
    public void OnclickContinueButton()
    {
        StartCoroutine(GameRestart());
    }

    IEnumerator GameRestart()
    {
        Debug.Log("PushButton");

        // 2秒（実時間）待つ
        yield return new WaitForSecondsRealtime(1);
        PausePanel.SetActive(false);
        // 現在のシーンを取得してロードする
        Scene GameScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(GameScene.name);
        Time.timeScale = 1;
        
    }
}
