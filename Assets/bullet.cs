﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
  public float speed = 20f;
  public int damage = 40;
  public Rigidbody2D rb;
  public GameObject impactEffect;


  // Start is called before the first frame update
  void Start()
  {
    rb.velocity = transform.right * speed;
  }

  void OnTriggerEnter2D(Collider2D hitInfo)
  {
    if (hitInfo.gameObject.tag == "Enemy" || hitInfo.gameObject.tag == "Wall" || hitInfo.gameObject.tag == "Bullet" || hitInfo.gameObject.tag == "Slope")
    {
      Debug.Log(hitInfo.name);
      Enemy enemy = hitInfo.GetComponent <Enemy> ();
      if (enemy != null)
      {
        enemy.TakeDamage(damage);
      }

      Instantiate(impactEffect, transform.position, transform.rotation);
      
      Destroy(gameObject);
      
    }

  }

}
