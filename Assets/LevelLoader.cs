using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    public Animator transition;

    // // Variable to adjust screen loading time
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Vertical"))
        {
            LoadNextLevel();
        }
    }


    

    // public string sceneToLoad;

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if(col.CompareTag("Player"))
    //     {
    //         Debug.Log("Player Entered");
    //         LoadNextLevel();
    //         if(Input.GetKeyDown("e"))
    //         {
    //             Debug.Log("E is Pressed ENTER");
    //             //SceneManager.LoadScene(sceneToLoad);
    //             LoadNextLevel();
    //             Debug.Log("After E is Pressed ENTER");
    //         }
    //     }
    // }
    // void OnTriggerStay2D(Collider2D col)
    // {
    //       if(col.CompareTag("Player"))
    //     {
    //         Debug.Log("Player Stayed");
    //         LoadNextLevel();
    //         if(Input.GetKeyDown("Vertical"))
    //         {
    //             Debug.Log("E is Pressed STAY");
    //             //SceneManager.LoadScene(sceneToLoad);
    //             LoadNextLevel();
    //             Debug.Log("After E is Pressed STAY");
    //         }
    //     }
    // }
    // void OnTriggerExit2D(Collider2D col)
    // {
    //     if(col.CompareTag("Player"))
    //         {
    //             Debug.Log("EXIT 2D");
    //         }
    // }



    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }



}
