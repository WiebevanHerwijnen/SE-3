using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject delft;
    public GameObject Deur2;
    public bool entered;
	public bool locked;
  


	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        delft = GameObject.Find("Lil Delft");

        Vector2 DeurLocatie2 = Deur2.transform.position;

		if (Input.GetKeyDown(KeyCode.E) && entered == true && locked == false)
        {
            delft.transform.position = DeurLocatie2;
           
        }
       
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        entered = true;

        

    }


    

    private void OnTriggerExit2D(Collider2D other)
    {
        entered = false;
    }

}
