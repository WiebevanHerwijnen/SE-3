using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
    public SpriteRenderer buttonrenderer;

    // Use this for initialization
    void Start()
    {
        buttonrenderer.enabled = false;


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("werkt");
        buttonrenderer.enabled = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonrenderer.enabled = false;
    }
}
