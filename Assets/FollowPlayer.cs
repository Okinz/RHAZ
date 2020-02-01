using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

  public Transform player;
  public Vector3 offset;
  public Vector3 leftBound = new Vector3(-11f, -1.4f, -10f);
  // Update is called once per frame
  void Update()
  {
    Debug.Log(player.position);
    Debug.Log(player.position + offset);
    if (Equals((player.position + offset), leftBound))
    {
      transform.position = player.position;
    }
    else
    {
      transform.position = player.position + offset;
    }

  }
}
