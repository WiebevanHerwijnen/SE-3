using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZuurKasScript : MonoBehaviour {
    public GameObject zuurkas;
    public GameObject delft;

    //other scipts
    Interaction interaction;

    private void Start()
    {
        interaction = delft.GetComponent<Interaction>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interaction.E_disable();
        
    }
  
}
