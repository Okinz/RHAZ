using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipDestruction : MonoBehaviour
{
  public int shipPoints = 100;
  public GameObject shipDoor;
  public float refreshTime = 0f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // if (refreshTime < Time.time)
    // {
    //   refreshTime += 2f;
    //   Debug.Log(refreshTime);
    // }
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Enemy")
    {
      shipPoints -= 10;
    }
    if (shipPoints == 0)
    {
      Destroy(gameObject);
      Destroy(shipDoor);
    }
  }
}
