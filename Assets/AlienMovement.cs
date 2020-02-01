using UnityEngine;

public class AlienMovement : MonoBehaviour
{
  public Rigidbody2D rb;
  private float thrust = 5.0f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void FixedUpdate()
  {
    rb.AddForce(Vector2.left * thrust);
  }
}
