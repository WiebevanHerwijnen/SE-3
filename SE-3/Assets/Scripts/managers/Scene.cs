using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    public void Load204()
    {
        SceneManager.LoadScene("204");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        //     Application.Quit;
        Debug.Log("Because I can");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Opening");
    }
}
