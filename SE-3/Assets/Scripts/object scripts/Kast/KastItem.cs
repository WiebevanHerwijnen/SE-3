using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastItem : MonoBehaviour {
    private SpriteRenderer itemrenderer;
    private GameObject kastitem;
    public bool pickedup;

	// Use this for initialization
	void Start () {
        kastitem = GameObject.Find("plastic bars va");
        itemrenderer = kastitem.GetComponent<SpriteRenderer>();

        //itemrenderer.enabled = false;
       // pickedup = true;
    }

    public void PickedUp()
    {
        Debug.Log("werkt");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
