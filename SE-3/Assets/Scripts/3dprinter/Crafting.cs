﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour {
    public GameObject keyformule;
    public Image keyblueprint;
    public Sprite lockedimage;
    public Image cancelbutton;
    public GameObject delft;
    public int listamount;
    public int amount = 2;
    public GameObject item;
    public GameObject itemspawner;
    
    
    

    //other script
    ItemTracker itemtrackerscript;
    ItemSpawn my_itemspawner;

    
    
    

    public void Start()
    {
        keyformule.SetActive(false);
        itemtrackerscript = delft.GetComponent<ItemTracker>();
        my_itemspawner = delft.GetComponent<ItemSpawn>();
    }


    private void Update()
    {
        listamount = itemtrackerscript.list_count;
    }

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
       if(listamount == amount)
        {
            itemtrackerscript.RemoveItems();
            itemtrackerscript.RemoveItems();
            MakeItem(item);
        }
    }
    public void MakeItem(GameObject item)
    {
        Instantiate(item);
        item.transform.position = itemspawner.transform.position;
    }

}