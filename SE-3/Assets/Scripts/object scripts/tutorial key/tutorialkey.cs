using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialkey : MonoBehaviour {
    public SpriteRenderer key;
    public bool ttkey;
    public bool close;
    public GameObject ttdoor;
    //public Sprite ttdoor;
	// Use this for initialization
	void Start () {
        ttkey = false;
        
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && close == true && GetComponent<BoxCollider2D>())
        {
            key.enabled = false;
            ttkey = true;
            Destroy(GetComponent<BoxCollider2D>());
           

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        close = true;
     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        close = false;

    }
}
