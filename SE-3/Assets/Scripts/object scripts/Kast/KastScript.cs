using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastScript : MonoBehaviour {
    public GameObject kast;
    public GameObject emptykast;
    public GameObject locatiedelft;
    public GameObject cursor;
    public BoxCollider2D colliderkast;
    public bool gebruikt;
    public bool opened;
   
    public bool nearby;
    

   
   
    

    private void Start()
    {        
        kast.transform.position = new Vector2(-10, -10);
        cursor = GameObject.Find("Cursor");
        opened = cursor.GetComponent<SelectCursorScript>().opened;

    }

    private void Update()
    {
        //opent de kast 
        if (nearby == true && Input.GetKeyDown(KeyCode.E) && opened == false)
        {
            emptykast.GetComponent<KastScript>().MoveKast();
            if (gebruikt == false)
            {
                cursor.GetComponent<SelectCursorScript>().itemcounter = 2;
                gebruikt = true;
            }
            cursor.GetComponent<SelectCursorScript>().Opening();

        }
        // doet de kast dicht
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            kast.transform.position = new Vector2(-10, -10);
            opened = false;
            
        }



    }

    public void OnTriggerEnter2D(Collider2D collision)//checked of Delft dichtbij genoeg is om de kast te openen
    {
        nearby = true;
        cursor.GetComponent<SelectCursorScript>().ItemCounterUp();

    }
    public void OnTriggerExit2D(Collider2D collision)//
    {
        nearby = false;
        kast.transform.position = new Vector2(-10, -10);
        cursor.GetComponent<SelectCursorScript>().ItemCounterDown();
        cursor.GetComponent<SelectCursorScript>().opened = false;
    }
    public void MoveKast()// verplaatst de KastInventory naar Delft
    {
        kast.transform.position = locatiedelft.transform.position;
        
    }







}
