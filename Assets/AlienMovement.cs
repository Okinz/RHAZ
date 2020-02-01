using UnityEngine;

public class AlienMovement : MonoBehaviour
{
  public Rigidbody2D rb;
  public Transform rocket;
  public Transform position;
  private float speed = 1.5f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float step = speed * Time.deltaTime;
    //transform.position = Vector2.MoveTowards()
    rb.AddForce(Vector2.MoveTowards() * speed);

  }
}
