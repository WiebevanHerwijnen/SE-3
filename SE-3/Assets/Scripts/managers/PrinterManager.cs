using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour {
    GameObject printerinventory;
    GameObject plasticbarinventoryslot ;
    GameObject keybp;
    public Collider2D colliderdelft;
    public bool nearby;
    public CanvasGroup pi;
    

	
	void Start () {
        printerinventory = GameObject.Find("printerinventory");
        printerinventory.SetActive(false);

        plasticbarinventoryslot = GameObject.Find("plasticbarinventoryslot");
        plasticbarinventoryslot.SetActive(false);

        keybp = GameObject.Find("keybp");
        keybp.SetActive(false);
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
        plasticbarinventoryslot.SetActive(true);
        keybp.SetActive(true);
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
