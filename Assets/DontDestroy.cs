using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("player");

        if (objs.Length > 1)
        {
            Destroy(transform.gameObject);
        }
        DontDestroyOnLoad (transform.gameObject);
    }
}