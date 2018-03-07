using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour {

    private bool nearby;
    private bool opened = false;
    private BoxCollider2D bx2d;
    public GameObject book;
    private int Page = 1;
    public GameObject Pagina1;
    public GameObject Pagina2;
    bool max;
    bool min;

	// Use this for initialization
	void Start () {

        bx2d = GetComponent<BoxCollider2D>();
        book.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d && opened == false)
        {
            Openbook();
            opened = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && nearby == true && bx2d && opened == true)
        {
            opened = false;
            Closebook();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && opened == true && nearby && bx2d && max == false)
        {
            Page += 1;
            UpdateBook();
            if (Page == 2)
            {
                max = true;
            }
            if (Page >= 2)
            {
                min = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && opened == true && nearby && bx2d && min == false)
        {
            Page -= 1;
            UpdateBook();
            if (Page == 1)
            {
                min = true;
            }
            if (Page <= 1)
            {
                max = false;
            }
        }

    }

    void UpdateBook()
    {
        if (Page == 1)
        {
            Pagina1.SetActive(true);
            Pagina2.SetActive(false);
        }
        else if (Page == 2)
        {
            Pagina1.SetActive(false);
            Pagina2.SetActive(true);
        }
    }

    void Openbook()
    {
        book.SetActive(true);
    }

    void Closebook()
    {
        book.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearby = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearby = false;
		opened = false;
		Closebook();
    }
}
