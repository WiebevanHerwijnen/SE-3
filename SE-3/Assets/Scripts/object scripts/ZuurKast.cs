using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZuurKast : MonoBehaviour {
    public GameObject delft;
    public GameObject erlenmeyer1;
    public GameObject erlenmeyer2;  
    public GameObject TP;
    public bool nearby;

    PopupManager popupManager;
    Interaction interaction;
    Movement movement;


    

	// Use this for initialization
	void Start () {
        popupManager = delft.GetComponent<PopupManager>();
        interaction = delft.GetComponent<Interaction>();
        movement = delft.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1) && nearby == true)
        {
           
            popupManager.Drankje1();
            interaction.Routine();
            delft.transform.position = TP.transform.position;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && nearby == true)
        {
          
            popupManager.Drankje2();
            interaction.Routine();
            movement.moveSpeed = 0.1f;
            Invoke("MoveSpeedBack", 20);
           

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
    public void MoveSpeedBack()
    {
        movement.moveSpeed = 1f;
    }

    
}
