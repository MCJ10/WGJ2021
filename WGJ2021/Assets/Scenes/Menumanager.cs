using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
     SceneManager.LoadScene("SampleScene");   
    }

    // Quit
    public void BotonQuit()
    {
     Debug.Log("Salir del juego");
     Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
