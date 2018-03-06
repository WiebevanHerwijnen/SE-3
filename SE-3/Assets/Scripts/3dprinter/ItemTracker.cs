using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour {
    //stuff for plasticbar
    public int plasticbarcounter;
    public Text plasticbaramout;
    public List<GameObject> items = new List<GameObject>();
    public GameObject plasticbar;

    //stuff for blueprints
    public GameObject keyblueprint;
    
	void Update () {

        plasticbaramout.text = plasticbarcounter.ToString();
        
       
    }
    public void PlasticBarAdded()
    {                
        plasticbarcounter++;
        items.Add(plasticbar);       
    }
}
