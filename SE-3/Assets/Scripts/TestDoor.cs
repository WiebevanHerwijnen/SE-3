using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoor : MonoBehaviour {
    public GameObject delft;
    public GameObject deur2;    
    public bool nearby;
    Vector2 deurlocatie2;
   public int keylistcount;
    public bool locked;
    

    //other scripts
    Crafting crafting;
    Interaction interaction;



	// Use this for initialization
	void Start () {
        
        deurlocatie2 = deur2.transform.position;
        crafting = delft.GetComponent<Crafting>();
        locked = true;
        interaction = delft.GetComponent<Interaction>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (locked == true && nearby == true)
        {
            interaction.noKey();
        }

        if (keylistcount == 1)
        {
            locked = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && nearby == true && locked == false)
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
