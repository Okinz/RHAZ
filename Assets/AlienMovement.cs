using UnityEngine;

public class AlienMovement : MonoBehaviour
{

  public Animator animator;
  public Rigidbody2D rb;
  public Transform rocket;
  private float speed = 3f;
  public float dirX;
  public bool facingRight = false;
  public Vector3 localScale;
  // Start is called before the first frame update
  void Start()
  {
    localScale = transform.localScale;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float step = speed * Time.deltaTime;
    transform.position = Vector2.MoveTowards(transform.position, rocket.position, step);
  }

  void CheckWhereToFace()
  {
    if (dirX > 0)
    {
      facingRight = true;
    }
    else if (dirX < 0)
    {
      facingRight = false;
    }
  }

  void OnTriggerEnter2D(Collider2D col)
  {
    switch (col.tag)
    {
      case "Slope":
        rb.AddForce(Vector2.up * 180f);
        break;
    }
  }
}
