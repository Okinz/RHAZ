using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemyWave : MonoBehaviour
{
  public GameObject alien;
  public float randX;
  public Vector2 whereToSpawn;
  private float repeatRate = .2f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Player")
    {
      InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
      Destroy(gameObject, 1);
      gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
  }
  void EnemySpawner()
  {
    randX = Random.Range(-23f, 19f);
    whereToSpawn = new Vector2(randX, 20f);
    Instantiate(alien, whereToSpawn, Quaternion.identity);
  }
}
