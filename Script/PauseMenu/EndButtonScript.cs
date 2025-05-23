using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButtonScript : MonoBehaviour
{
    [SerializeField] GameObject gamePausePanel;
    [SerializeField] GameObject soundControllerPanel;
    public void OnClickEndButton()
    {
        gamePausePanel.SetActive(true);
        soundControllerPanel.SetActive(false);
        Time.timeScale = 0;
    }
}
