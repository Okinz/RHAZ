using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
  public Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void FixedUpdate()
  {
    rb.AddForce(1000 * Time.deltaTime, 0, 0);
  }
}
