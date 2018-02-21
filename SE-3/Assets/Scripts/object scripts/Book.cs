using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour {

    private bool nearby;
    private bool opened = false;
    private BoxCollider2D bx2d;

	// Use this for initialization
	void Start () {

        bx2d = GetComponent<BoxCollider2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d && opened == false)
        {
            Openbook();
            opened = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d && opened == true)
        {
            opened = false;
            Closebook();
        }


	}

    void Openbook()
    {
        Debug.Log("ja");
    }

    void Closebook()
    {
        Debug.Log("nee");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearby = false;
    }
}
