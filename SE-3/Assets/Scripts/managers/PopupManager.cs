using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopupManager : MonoBehaviour {
    public GameObject meshrenderer;   
    public MeshRenderer mr;
    public TextMesh popuptm;
  
    public GameObject Tbutton;
  
    

    

    private void Start()
    {
        meshrenderer = GameObject.Find("popup_meshrenderer");
        

        mr = meshrenderer.GetComponent<MeshRenderer>();
        mr.enabled = false;

        popuptm = meshrenderer.GetComponent<TextMesh>();
        HideT();
    }

    public void EnableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
    {
        mr.enabled = true;
    }
	public void DisableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
	{
		mr.enabled = false;
	}

   

    public void PickedUpBluePrintKey()
    {
        popuptm.text = "blueprint key ontgrendelt";
        ShowBoard();
    }

    public void ShowBoard()
    {
        
        mr.enabled = true;
        
    }
    public void HideBoard()
    {
       
        mr.enabled = false;            
    }

    public void Drankje1()
    {
        popuptm.text = "HUH?!?!";
        ShowBoard();
        Invoke("HideBoard", 2);
    }
    
    public void Drankje2()
    {
        popuptm.text = "OpGEdr0NK3n: Gek Gr03n drANKj3";
        ShowBoard();
        Invoke("HideBoard", 2);
    }

    public void ShowT()
    {
        Tbutton.SetActive(true);
    }

    public void HideT()
    {
        Tbutton.SetActive(false);
    }
}
