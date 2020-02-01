using UnityEngine;

public class AlienMovement : MonoBehaviour
{
  public Rigidbody2D rb;
  public Transform rocket;
  //public Vector2 position;
  private float speed = 3f;
  // Start is called before the first frame update
  void Start()
  {
    //position = gameObject.transform.position;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float step = speed * Time.deltaTime;
    // //transform.position = Vector2.MoveTowards()
    transform.position = Vector2.MoveTowards(transform.position, rocket.position, step);

  }
}
