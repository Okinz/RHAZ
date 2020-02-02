using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtSceneChange : MonoBehaviour
{
    
    public Animator transition;

    // Variable to adjust screen loading time
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("SceneChange"))
        {
            LoadNextLevel();
        }
    }


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex -1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }
}
