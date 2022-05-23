using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class control_escenas : MonoBehaviour
{
    
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void opciones()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4 );

    }

    public void volver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);

    }

    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

}

