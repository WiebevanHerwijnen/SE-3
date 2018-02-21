using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject delft;
    public GameObject Deur2;
	public SpriteRenderer srkey;
    public bool entered;
	public bool locked;

	// Use this for initialization
	void Start () {
		

    }
	
	// Update is called once per frame
	void Update () {
        delft = GameObject.Find("Lil Delft"); //zoek de player op en stored het als een gameobject

        Vector2 DeurLocatie2 = Deur2.transform.position;//bekijkt waar de locatie van de tweede deur is

		if (Input.GetKeyDown (KeyCode.E) && entered == true && locked == false) {
			delft.transform.position = DeurLocatie2;
			AudioSource audio = delft.GetComponent<AudioSource>();
			audio.Play();
		} else if (Input.GetKeyDown (KeyCode.E) && entered == true && locked == true) {
			delft.GetComponent<Interaction> ().noKey ();
			Debug.Log("Op slot");
		}


       
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        entered = true;
		if(srkey.enabled == false)
		{
			locked = false;
		}
    }


    

    private void OnTriggerExit2D(Collider2D other)
    {
        entered = false;
    }

}
