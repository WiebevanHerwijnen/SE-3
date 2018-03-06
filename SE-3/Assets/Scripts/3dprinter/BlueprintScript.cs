using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueprintScript : MonoBehaviour {
    //blueprint variable
    public GameObject blueprint;
    public Image blueprintinventorylocked;
    SpriteRenderer srblueprint;   
    BoxCollider2D boxcolliderblueprint;
    public Sprite blueprintinventoryactive;
    bool nearby;

    public GameObject lildelft;

    
    //other scipts
    PopupManager popupboard;
    
    //geeft de variable een waarde
    private void Start()
    {
        srblueprint = blueprint.GetComponent<SpriteRenderer>();
        boxcolliderblueprint = blueprint.GetComponent<BoxCollider2D>();
        popupboard = lildelft.GetComponent<PopupManager>();
    }
    private void Update()
    {
        PickUpBluePrint(blueprint);
    }

    //zorgt ervoor dat de inventory wordt geupdate
    public void PickUpBluePrint(GameObject blueprint)
    {
        if (nearby == true && Input.GetKeyDown(KeyCode.E))
        {
            srblueprint.enabled = false;
            blueprintinventorylocked.sprite = blueprintinventoryactive;
            Destroy(boxcolliderblueprint);
            popupboard.PickedUpBluePrintKey();
           
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;      
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        nearby = false;
    }





}
