using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprints : MonoBehaviour {
	private bool nearby;
	private SpriteRenderer sr;
	public SpriteRenderer sr_object;
	private BoxCollider2D bx2d;
	public bool pickedup;

	// Use this for initialization
	void Start () {
		nearby = false;
		pickedup = false;
		sr = GetComponent<SpriteRenderer>();
		bx2d = GetComponent<BoxCollider2D>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d)
		{
			sr.enabled = false;
			sr_object.enabled = true;
			Destroy(bx2d);
			pickedup = true;       
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
