using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
    public SpriteRenderer buttonrenderer;
	public SpriteRenderer nokeyrenderer;

    // Use this for initialization
    void Start()
    {
        buttonrenderer.enabled = false;
		nokeyrenderer.enabled = false;

    }

    private void Update()
    {
      
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("werkt");
        buttonrenderer.enabled = true;

    }
	public void noKey() 
	{
		nokeyrenderer.enabled = true;
	}
    private void OnTriggerExit2D(Collider2D other)
    {
        buttonrenderer.enabled = false;
		nokeyrenderer.enabled = false;
    }
}
