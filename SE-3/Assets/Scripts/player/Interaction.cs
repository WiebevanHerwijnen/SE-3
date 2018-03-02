using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
    public SpriteRenderer buttonrenderer;
	public SpriteRenderer nokeyrenderer;
    public GameObject pop_up;
    public SpriteRenderer pop;
    public GameObject mrobject;
    public GameObject kast;

    // Use this for initialization
    void Start()
    {
        buttonrenderer.enabled = false;
		nokeyrenderer.enabled = false;
        pop_up = GameObject.Find("text popup");
        pop = pop_up.GetComponent<SpriteRenderer>();
        pop.enabled = false;
      
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        buttonrenderer.enabled = true;
        

    }
	public void noKey() 
	{
		nokeyrenderer.enabled = true;
	}
    
    private void Hold_Popup()
    {
        pop.enabled = false;
		mrobject.GetComponent<PopupManager>().DisableMeshRendererKeyPickUp();// called the functie die de meshrenderer onzichtbaarmaakt(werkt nog niet)
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonrenderer.enabled = false;
		nokeyrenderer.enabled = false;
        if (Input.GetKeyDown(KeyCode.E))
        {
            pop.enabled = true;           
            Invoke("Hold_Popup", 1);
            mrobject.GetComponent<PopupManager>().EnableMeshRendererKeyPickUp();// called the functie die de meshrenderer zichtbaarmaakt(werkt nog niet)


        }
        
    }

}
