using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoor : MonoBehaviour {
    public GameObject delft;
    public GameObject deur2;    
    public bool nearby;
    Vector2 deurlocatie2;
   public int keylistcount;

    //other scripts
    Crafting crafting;


	// Use this for initialization
	void Start () {
        deurlocatie2 = deur2.transform.position;
        crafting = delft.GetComponent<Crafting>();
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && nearby == true)
        {
            delft.transform.position = deurlocatie2;
           
        }
       keylistcount = crafting.keylist.Count;
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
