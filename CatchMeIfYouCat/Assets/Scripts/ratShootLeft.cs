﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratShootLeft : MonoBehaviour {

  float speed;
  int direction;

  // Use this for initialization
  void Start () {
    direction = -1;
    speed = 10f * direction;
	}
	
	// Update is called once per frame
	void Update () {
    Vector2 position = transform.position;
    position = new Vector2(position.x + speed * Time.deltaTime, position.y);
    
    transform.position = position;

    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1 ));
    
    if(transform.position.x > max.x) {
      Destroy(gameObject);
    } else {
      Destroy(gameObject, 0.5f);
      //Debug.Log("it must die!");
    }    
	}

  void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "cat") {
      GameManager.health--;
      Debug.Log("health "  + GameManager.health);
      GameManager.checkIfLoose();
		}
    if(col.gameObject.tag != "rat")
      Destroy(gameObject);
  }
}
