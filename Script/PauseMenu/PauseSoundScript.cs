using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSoundScript : MonoBehaviour
{
    [SerializeField] GameObject soundControllerPanel;

    public void OnclickSoundControllerPanel()
    {
        soundControllerPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
