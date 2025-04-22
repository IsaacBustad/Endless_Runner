using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_SceneLoader : MonoBehaviour
{
    // Vars
    

    // Methods
    public void LoadScene()
    {
        //SceneManager.LoadScene(0);
        //SceneManager.LoadScene("Test2");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.GetActiveScene();
    }
}
