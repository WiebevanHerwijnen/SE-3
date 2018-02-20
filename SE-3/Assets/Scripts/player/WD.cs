using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WD : MonoBehaviour {
    public Sprite W;
    public Sprite A;
    public Sprite S;
    public Sprite D;
    private bool w;
    private bool a;
    private bool s;
    private bool d;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        #region 
        //makes de sprite of the player change when a certain button is pressed
		if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = A;
            a = true;

        }
		if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = W;
            w = true;

        }
		if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            s = true;

        }
		if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = D;
            d = true;
        }
        #endregion
        if (Input.GetKeyUp(KeyCode.A))
        {
            
            a = false;

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
         
            w = false;

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
          
            s = false;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            
            d = false;
        }


    }
}
