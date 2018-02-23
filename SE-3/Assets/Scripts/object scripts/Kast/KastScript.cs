using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastScript : MonoBehaviour {
    public GameObject kast;
    public GameObject locatiedelft;
    public BoxCollider2D colliderkast;
    public float Ecount;
    public bool nearby;
   
   
    

    private void Start()
    {        
        kast.transform.position = new Vector2(-10, -10);              
    }

    private void Update()
    {
        if (nearby == true && Input.GetKeyDown(KeyCode.E))
        {
            kast.transform.position = locatiedelft.transform.position;
            Ecount++;
        }
        if (Input.GetKeyDown(KeyCode.E) && Ecount == 2f)
        {
            kast.transform.position = new Vector2(-10, -10);
            Ecount = 0f;
        }



    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        nearby = true;
        kast.transform.position = new Vector2(-10, -10);
        Ecount = 0f;
    }







}
