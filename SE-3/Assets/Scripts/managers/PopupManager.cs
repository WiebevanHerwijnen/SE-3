using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour {
    public GameObject meshrenderer;
    public MeshRenderer mr;

    private void Start()
    {
        meshrenderer = GameObject.Find("popup_meshrenderer");
        mr = meshrenderer.GetComponent<MeshRenderer>();
        mr.enabled = false;
    }

    public void EnableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
    {
        mr.enabled = true;
    }
	public void DisableMeshRendererKeyPickUp() // maakt de meshrenderer zichtbaar
	{
		mr.enabled = false;
	}
}
