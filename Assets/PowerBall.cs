using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBall : MonoBehaviour
{
  
  public Rigidbody2D rb;


  
  void Start()
  {
      rb.mass = 1;
  }

  void OnTriggerEnter2D(Collider2D hitInfo)
  {
    if (hitInfo.gameObject.tag == "Player")
    {
        //Add one powerball to inventory
      
      
      Destroy(gameObject);
      
    }

  }
}