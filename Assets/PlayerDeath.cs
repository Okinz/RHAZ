using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
  public int lifePoints = 10;
  public float previousXCoor;
  public Rigidbody2D rb;
  public bool movingRight = false;
  // Start is called before the first frame update
  void Start()
  {
    previousXCoor = transform.position.x;
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.x < previousXCoor)
    {
      movingRight = false;
      previousXCoor = transform.position.x;
    }
    else if (transform.position.x > previousXCoor)
    {
      movingRight = true;
      previousXCoor = transform.position.x;
    }
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Enemy")
    {
      lifePoints -= 1;
      if (movingRight)
      {
        rb.AddForce(Vector2.left * 1000f);
      }
      else if (!movingRight)
      {
        rb.AddForce(Vector2.right * 1000f);
      }
      Debug.Log(lifePoints);
    }
    if (lifePoints == 0)
    {
      Destroy(gameObject);
    }
  }
}
