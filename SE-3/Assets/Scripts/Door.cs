﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Collider2D coll;
   

	// Use this for initialization
	void Start () {
        


    }
	
	// Update is called once per frame
	void Update () {
        coll = gameObject.GetComponent<BoxCollider2D>();
       
        
	}

    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("werkt");
        

    }

    
}
