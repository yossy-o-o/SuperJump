using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WagonDestroy : MonoBehaviour
{
    [SerializeField] GameObject wagon;
    [SerializeField] Button BuyButtonPanel;
    
    public int DestroyTime;

    public void Start()
    {
        Invoke("Destroy", DestroyTime);
    }

    public void OnclickBuyButton()
    {
        Destroy();
    }

    private void Destroy()
    {
        Destroy(wagon);
    }
}
