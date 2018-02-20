using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
    public Collider2D coll;
    public SpriteRenderer buttonrenderer;
    public Rigidbody2D delftrb;

    // Use this for initialization
    void Start()
    {
        buttonrenderer.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        coll = gameObject.GetComponentInParent<BoxCollider2D>();
        delftrb = gameObject.GetComponentInParent<Rigidbody2D>();


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
