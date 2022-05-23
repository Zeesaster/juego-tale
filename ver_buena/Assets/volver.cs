using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{

    public void Volverr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }

}
