using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour {
    
    public GameObject itemspawner;

    //other script
    
   

    public void MakeItem(GameObject item)
    {
        Instantiate(item);
        item.transform.position = itemspawner.transform.position;
       
    }
}
