using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        // Loads the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }


    public void QuitGame()
    {
        // Will exit program on executable but not unity
        Application.Quit();
    }
}
