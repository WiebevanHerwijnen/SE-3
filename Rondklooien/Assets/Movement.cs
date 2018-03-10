using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D plane;
    float currentspeed;
    float speed;
    float multiplier;
    float maxspeed;

	// Use this for initialization
	void Start () {
        speed = 2f;
        multiplier = 1.1f;
        currentspeed = speed * multiplier;
        maxspeed = 20f;
        plane.transform.position = new Vector2(0f, 0f); 
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
        {
            plane.transform.position * new Vector2 ( 0f, Input.GetKeyDown(KeyCode.W))
           
        }
	}
}
