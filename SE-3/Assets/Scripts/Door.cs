using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Collider2D coll;
    public SpriteRenderer buttonrenderer;

	// Use this for initialization
	void Start () {
        buttonrenderer.enabled = false;


    }
	
	// Update is called once per frame
	void Update () {
        coll = gameObject.GetComponent<BoxCollider2D>();
        buttonrenderer = GetComponentInChildren<SpriteRenderer>();
        
	}

    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("werkt");
        buttonrenderer.enabled = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonrenderer.enabled = false;
    }
}
