using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour {
    public SpriteRenderer printerinventory;
    public Collider2D colliderdelft;
    public bool nearby;

	
	void Start () {
        printerinventory.enabled = false;
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && nearby == true)
        {
            ShowInventory();
        }
	}

    public void ShowInventory()
    {
        printerinventory.enabled = true;
    }


    public void OnTriggerEnter2D(Collider2D colliderdelft)
    {
        nearby = true; 
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        nearby = false;
    }
}
