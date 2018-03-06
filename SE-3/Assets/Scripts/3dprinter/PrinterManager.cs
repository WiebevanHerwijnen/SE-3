using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour {
    GameObject printerinventory;   
    public Collider2D colliderdelft;
    public bool nearby;
   
    

	
	void Start () {
        printerinventory = GameObject.Find("PI(canvas)");
        printerinventory.SetActive(false);     
    }
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && nearby == true)
        {
            ShowInventory();
        }
	}

    public void ShowInventory()
    {
        printerinventory.SetActive(true);
       
    }


    public void OnTriggerEnter2D(Collider2D colliderdelft)
    {
        nearby = true; 
    }
    public void OnTriggerExit2D(Collider2D colliderdelft)
    {
        nearby = false;
        printerinventory.SetActive(false);
    }
}
