using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
    //lists
    public List<GameObject> hearts = new List<GameObject>();
    //GO
    public GameObject heart;
    //other
    public Transform HeartPanel;
    public int heartcount;

	// 40.5 pixels
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AddHeart();
           
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            RemoveHeart();

        }



        heartcount = hearts.Count;
    }
    public void AddHeart()
    {
        heart = Instantiate(heart);
        heart.transform.parent = HeartPanel;
        hearts.Add(heart);
    }

    public void RemoveHeart()
    {
        hearts.Remove(heart);
    }
}
