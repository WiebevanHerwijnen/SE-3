﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastScript : MonoBehaviour {
    public GameObject kast;
    public GameObject emptykast;
    public GameObject locatiedelft;
    public BoxCollider2D colliderkast;
   
    public bool nearby;
   
   
    

    private void Start()
    {        
        kast.transform.position = new Vector2(-10, -10);              
    }

    private void Update()
    {
        if (nearby == true && Input.GetKeyDown(KeyCode.E))
        {
            emptykast.GetComponent<KastScript>().MoveKast();  
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            kast.transform.position = new Vector2(-10, -10);
            
        }



    }

    public void OnTriggerEnter2D(Collider2D collision)//checked of Delft dichtbij genoeg is om de kast te openen
    {
        nearby = true;
    }
    public void OnTriggerExit2D(Collider2D collision)//
    {
        nearby = false;
        kast.transform.position = new Vector2(-10, -10);
     
    }
    public void MoveKast()// verplaatst de KastInventory naar Delft
    {
        kast.transform.position = locatiedelft.transform.position;
        
    }







}
