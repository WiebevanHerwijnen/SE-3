using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject textObject;
    public GameObject sprite;
    public GameObject sleutel;
    bool W;
    bool A;
    bool S;
    bool D;
    bool Pagina1 = true;

	// Use this for initialization
	void Start () {

        sleutel.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.W))
        {
            W = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }

        if (W && A && S && D && Pagina1 == true)
        {
            Pagina2();
            Pagina1 = false;
            sprite.SetActive(false);
        }
    }

    public void Pagina2()
    {
        sleutel.SetActive(true);
        textObject.GetComponent<TextMesh>().text = "Perfect!" + "\n" + "\n" + "Dan hebben we nu een ander probleem... " + "\n" + "De deur zit op slot..    Maar! ik weet wel iets!" + "\n" + "Volgensmij lag daar ergens bij de kast een sleutel?" + "\n" + "\n" + "Hij zag er volgensmij zo uit!:";
    }
}
