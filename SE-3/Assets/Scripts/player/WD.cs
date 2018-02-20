using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WD : MonoBehaviour {
    public Sprite W;
    public Sprite A;
    public Sprite S;
    public Sprite D;
    
    


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
        

        }
		if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = W;
          

        }
		if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
         

        }
		if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = D;
           
        }
        #endregion
       

    }
}
