using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCursorScript : MonoBehaviour {
    private GameObject selectcursor;
    public GameObject kast;
    public GameObject Lildelft;
    public SpriteRenderer item1;
    public SpriteRenderer item2;
    public int itemcounter;

    // Use this for initialization
    void Start() {
        selectcursor = GameObject.Find("select cursor");
        selectcursor.transform.position = item1.transform.position;
        itemcounter = 1;      
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.T) )
        {
            selectcursor.GetComponent<SelectCursorScript>().PickUpItem();
        }
    }
   public void PickUpItem()
    {
        item1.enabled = false; 
    }
}
