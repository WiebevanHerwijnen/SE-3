using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
    //lists
    public List<GameObject> hearts = new List<GameObject>();
    //GO
    public GameObject heart;
    public int heartcount;

	// 40.5 pixels
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hearts.Add(heart);
           
        }
        Instantiate(heart);

        heartcount = hearts.Count;
    }
    public void AddHeart()
    {

    }
}
