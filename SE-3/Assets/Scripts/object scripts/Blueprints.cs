using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprints : MonoBehaviour {
	private bool nearby;
	private SpriteRenderer sr;
	public SpriteRenderer sr_object;
	private BoxCollider2D bx2d;
	public BoxCollider2D bx2d_object;
	public bool pickedup;
	//Maak game object om pop-up te selecteren
	public GameObject pop_up;

	// Use this for initialization
	void Start () {
		nearby = false;
		pickedup = false;
		sr = GetComponent<SpriteRenderer>();
		bx2d = GetComponent<BoxCollider2D>();
		//Zoek de pop-up meshrenderer om de text aan te kunnen passen
		pop_up = GameObject.Find("popup_meshrenderer");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d)
		{
			sr.enabled = false;
			sr_object.enabled = true;
			bx2d_object.enabled = true;
			Destroy(bx2d);
			pickedup = true;   
			//Verander de text van de pop-up
			pop_up.GetComponent<TextMesh>().text = "Opgepakt: Blueprint";
		}

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		nearby = true;
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		nearby = false;
	}

}
