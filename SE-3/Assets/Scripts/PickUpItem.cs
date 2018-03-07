using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {
    public GameObject item;
     public bool nearby;
    public BoxCollider2D colliderprefab;

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

    private void OnCollisionEnter2D(Collision2D colliderprefab)
    {
        nearby = true;
    }
    private void OnCollisionExit2D(Collision2D colliderprefab)
    {
        nearby = false;
    }
}
