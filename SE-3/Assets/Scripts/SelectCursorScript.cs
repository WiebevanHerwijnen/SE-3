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
    public bool pickedup1;
    public bool pickedup2;
    public int selected = 0;
    public bool opened = false;

    //scripts
    SelectCursorScript popupboard;

    


   
    void Start() {
        cursor = GameObject.Find("Cursor");       
        itemcounter = 0;
        nearby = false;
        popupboard = popupboard.GetComponent<SelectCursorScript>();

        


    }

   
    void Update() {
        //verplaatst de cursor naar het eerste voorwerp
        if (Input.GetKeyDown(KeyCode.LeftArrow) && itemcounter == 3)
        {
            
            itemcounter--;
            cursor.transform.position = item1.transform.position;
            selected = 0;
            
        }
        //pakt item 2 op
        if(Input.GetKeyDown(KeyCode.E) && itemcounter == 3 && selected == 1 && opened == true)
        {
            PickUpItem2();
           
        }
        //pakt item 1 op
        if (Input.GetKeyDown(KeyCode.E) && itemcounter == 2 && selected == 0 && opened == true)
        {
            PickUpItem1();
            //popupboard.GetComponent<PopupManager>().PickedUpPlasticBar();
            
        }
        //verplaatst de cursor naar het tweede item
        if (Input.GetKeyDown(KeyCode.RightArrow) && itemcounter == 2)
        {
            cursor.transform.position = item2.transform.position;
            itemcounter++;
            selected = 1;
        }
    }
    // functie voor het oppakken van item 1
   public void PickUpItem1()
    {
       item1.enabled = false;
        
        
        if(item2.enabled == true)
        {
            cursor.transform.position = item2.transform.position;
            itemcounter = 3;
            selected = 1;
        }
        else if (item2.enabled == false)
        {
            cursor.transform.position = new Vector2(-11, -11);
        }
    }
    //functie voor het oppakken van item 2
    public void PickUpItem2()
    {
         item2.enabled = false;
        
        
        if (item1.enabled == true)
        {
            cursor.transform.position = item1.transform.position;
            itemcounter--;
            selected = 0;
        }
        else if (item1.enabled == false)
        {
            cursor.transform.position = new Vector2(-11, -11);
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
    //kijken of de kast geopend is
    public void Opening()
    {
        if (opened == true)
        {
            opened = false;
        }
        if (opened == false)
        {
            opened = true;
        }
    }

}
