using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

  public Transform player;
  public Vector3 offset;
  public float leftBound = -10f;
  public float rightBound = 7f;
  // Update is called once per frame
  void Update()
  {
    Debug.Log(player.position + offset);
    if ((player.position + offset).x < leftBound)
    {
      transform.position = transform.position;
    }
    else if ((player.position + offset).x > rightBound)
    {
      transform.position = transform.position;
    }
    else
    {
      transform.position = player.position + offset;
    }
  }
}
