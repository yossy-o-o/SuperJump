using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField] GameObject ReturnPanel;

    public void ReturnGame()
    {
        ReturnPanel.SetActive(false);
    }
}
