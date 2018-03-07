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
    public int list_count;
    

    //stuff for blueprints
    public GameObject keyblueprint;
    private void Start()
    {
        
    }


    public void Update () {

        plasticbaramout.text = plasticbarcounter.ToString();
        list_count = items.Count;

    }
    public void PlasticBarAdded()
    {                
        plasticbarcounter++;
        items.Add(plasticbar);
        
    }

    public void RemoveItems()
    {
        items.Remove(plasticbar);
        items.Remove(plasticbar);
        plasticbarcounter = plasticbarcounter - 2;
      

    }
}
