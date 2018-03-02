using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour {
    private GameObject meshrenderer;   
    private MeshRenderer mr;
    private TextMesh popuptm;
    public GameObject board;

    private void Start()
    {
        meshrenderer = GameObject.Find("popup_meshrenderer");

        mr = meshrenderer.GetComponent<MeshRenderer>();
        mr.enabled = false;

        popuptm = meshrenderer.GetComponent<TextMesh>();
    }

    public void EnableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
    {
        mr.enabled = true;
    }
	public void DisableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
	{
		mr.enabled = false;
	}
    public void PickedUpPlasticBar()
    {
        popuptm.text = "opgepakt plasticbar";
        MakeBoardVisible();

              
    }

    public void MakeBoardVisible()
    {
       
    }
}
