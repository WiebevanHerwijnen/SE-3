using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour {
    public GameObject printerinventory;   
    public Collider2D colliderdelft;
    public bool nearby;
    public GameObject key;
    public GameObject delft;
    public int keylist;

    //other script
    Crafting crafting;
    PopupManager popupmanager;

   
    

	
	void Start () {       
        printerinventory.SetActive(false);
        crafting = delft.GetComponent<Crafting>();
        popupmanager = delft.GetComponent<PopupManager>();
      

    }
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && nearby == true)
        {
            ShowInventory();
        }
        if (Input.GetKeyDown(KeyCode.T) && nearby == true)
        {
            key.SetActive(false);
            crafting.AddKeyToList();           
        }
        key = GameObject.FindGameObjectWithTag("Key");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            printerinventory.SetActive(false);
        }
    }

    public void ShowInventory()
    {
        printerinventory.SetActive(true);
       
    }
    public void HideInventory()
    {
        printerinventory.SetActive(false);
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
