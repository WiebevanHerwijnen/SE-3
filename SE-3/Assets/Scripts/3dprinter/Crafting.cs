using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour {
    //gameobjects
    public GameObject keyformule;
    public GameObject delft;
    public GameObject item;
    public GameObject itemspawner;
    public GameObject key;
    //sprites
    public Image keyblueprint;
    public Sprite lockedimage;
    public Image cancelbutton;
    //variables
    public int listamount;
    public int amount = 2;
    //lists
    public List<GameObject> keylist = new List<GameObject>();   
    //other script
    ItemTracker itemtrackerscript;
    
    PopupManager popupmanager;
   






#region start and update
    public void Start()
    {
        keyformule.SetActive(false);
        itemtrackerscript = delft.GetComponent<ItemTracker>();
        
        popupmanager = delft.GetComponent<PopupManager>();
       
    }


    private void Update()
    {
        listamount = itemtrackerscript.list_count;
    }
    #endregion
#region blueprint functions

    public void ClickKeyBluePrint()
    {
        keyformule.SetActive(true);
        
    }

    public void CheckIfLocked()
    {
        if(keyblueprint.sprite == lockedimage)
        {
            keyformule.SetActive(false);
        }
        else
        {
            ClickKeyBluePrint();
        }
    }
    public void CloseWindow(GameObject currentwindow)
    {
        currentwindow.SetActive(false);
    }

    public void Confirm()
    {
        ProducePlasticBar();
    }
    public void ProducePlasticBar()
    {
       if(listamount >= amount)
        {
            
            itemtrackerscript.RemoveItems();           
            MakeItem(item);
           
        }
    }
    public void MakeItem(GameObject item)
    {
        Instantiate(item);
        item.transform.position = itemspawner.transform.position;
        popupmanager.ShowT();
            }
#endregion

    public void AddKeyToList()
    {
        keylist.Add(key);
    }


}
