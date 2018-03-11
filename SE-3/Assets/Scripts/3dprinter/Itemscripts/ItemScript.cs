using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {
    public GameObject delft;
    public GameObject item;
    public bool nearby;

    //other scripts
    PopupManager popupManager;

    private void Start()        
    {
        delft = GameObject.Find("Lil Delft");
        popupManager = delft.GetComponent<PopupManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;
        popupManager.ShowT();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearby = false;
        popupManager.HideT();
    }
}
