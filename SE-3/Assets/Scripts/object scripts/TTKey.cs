using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTKey : MonoBehaviour {
    private bool nearby;
    private SpriteRenderer sr;
    private BoxCollider2D bx2d;
    public bool pickedup;
   
    
    

	// Use this for initialization
	void Start () {
        nearby = false;
        pickedup = false;
        sr = GetComponent<SpriteRenderer>();
        bx2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d)
        {
            sr.enabled = false;
            Destroy(bx2d);
            pickedup = true;       
        }
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;
    }
}
