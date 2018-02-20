using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Collider2D coll;

   

    public SpriteRenderer buttonrenderer;
    public GameObject delft;
    //public GameObject Deur1;
    public GameObject Deur2;
    public bool entered;


	// Use this for initialization
	void Start () {
        


    }
	
	// Update is called once per frame
	void Update () {
        coll = gameObject.GetComponent<BoxCollider2D>();

       
        

        buttonrenderer = GetComponentInChildren<SpriteRenderer>();
        delft = GameObject.Find("Lil Delft");

        //Vector2 DeurLocatie1 = Deur1.transform.position;
        Vector2 DeurLocatie2 = Deur2.transform.position;

        if (Input.GetKeyDown(KeyCode.E) && entered == true)
        {
            delft.transform.position = DeurLocatie2;
           
        }

	}

    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("werkt");


        buttonrenderer.enabled = true;
        entered = true;

        

    }


    

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonrenderer.enabled = false;
        entered = false;
    }

}
