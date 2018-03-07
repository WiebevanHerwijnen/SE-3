using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {
    public GameObject item;
     public bool nearby;

    private void Update()
    {
        PickUp();
    }
    void PickUp()
    {
        if(nearby == true && Input.GetKeyDown(KeyCode.T))
        {
            Destroy(item);
        }
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
