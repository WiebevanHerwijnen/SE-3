using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour {
    public Text plasticbartext;
    public int pbcounter;
    public GameObject[] plasticbar;

    // Use this for initialization
    void Start() {
      
    }

    // Update is called once per frame
    void Update() {
        plasticbartext.text = pbcounter.ToString("0");
        plasticbar = GameObject.FindGameObjectsWithTag("plasticbar");      
    }

    

}
