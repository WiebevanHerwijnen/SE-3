using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCursorScript : MonoBehaviour {
    private GameObject cursor;
    public GameObject kast;
    public GameObject Lildelft;
    public SpriteRenderer item1;
    public SpriteRenderer item2;
    public int itemcounter;
    public bool nearby;
    


    // Use this for initialization
    void Start() {
        cursor = GameObject.Find("Cursor");
        itemcounter = 0;
        nearby = false;
        


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && itemcounter == 3)
        {
            
            itemcounter--;
            cursor.transform.position = item1.transform.position;
          
        }
        if(Input.GetKeyDown(KeyCode.T) && itemcounter == 3)
        {
            PickUpItem2();
        }
        if (Input.GetKeyDown(KeyCode.T) && itemcounter == 2)
        {
            PickUpItem1();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && itemcounter == 2)
        {
            cursor.transform.position = item2.transform.position;
            itemcounter++;                                               
        }
    }
   public void PickUpItem1()
    {
       item1.enabled = false; 
        if(item2.enabled == true)
        {
            cursor.transform.position = item2.transform.position;
            itemcounter++;
        }
        else if (item2.enabled == false)
        {
            cursor.transform.position = new Vector2(-10, -10);
        }
    }
    public void PickUpItem2()
    {
         item2.enabled = false;
        if (item1.enabled == true)
        {
            cursor.transform.position = item1.transform.position;
            itemcounter--;
        }
        else if (item1.enabled == false)
        {
            cursor.transform.position = new Vector2(-10, -10);
        }
    }
    public void ItemCounterUp()
    {
        itemcounter++;
    }
    public void ItemCounterDown()
    {
        itemcounter--;
    }

}
