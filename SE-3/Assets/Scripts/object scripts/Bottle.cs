using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {
	public GameObject delft;
	private bool nearby;
	private SpriteRenderer sr;
	private BoxCollider2D bx2d;
	public bool pickedup;
	//Maak game object om pop-up te selecteren
	public GameObject pop_up;
	//other scripts
	float movement_script;

	// Use this for initialization
	void Start () {
		nearby = false;
		pickedup = false;
		sr = GetComponent<SpriteRenderer>();
		bx2d = GetComponent<BoxCollider2D>();
		//Zoek de pop-up meshrenderer om de text aan te kunnen passen
		pop_up = GameObject.Find("popup_meshrenderer");
		delft = GameObject.Find("Lil Delft"); //zoek de player op en stored het als een gameobject
		movement_script = delft.GetComponent<Movement>().moveSpeed;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d)
		{
			// sr.enabled = false;
			// Destroy(bx2d);
			// pickedup = true;
			//Verander de text van de pop-up
			//pop_up.GetComponent<TextMesh>().text = "Opgepakt: Sleutel";
			PickedUpPoison();
		}

	}
	public void PickedUpPoison()
	{
		sr.enabled = false;
		Destroy(bx2d);
		pickedup = true;
		//Verander de text van de pop-up
		pop_up.GetComponent<TextMesh>().text = "OpGEdr0NK3n: Gek Gr03n drANKj3";
		delft.GetComponent<Movement>().moveSpeed = 0.1f;

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
