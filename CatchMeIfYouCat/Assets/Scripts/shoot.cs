using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
float speed;
float distance;
public bool isLeft;
	// Use this for initialization
	void Start () {
		speed = 15f;
    distance = transform.position.x + 3;
	}
	
	// Update is called once per frame
	void Update () {
    
    if(Input.GetKeyDown("left")) {
      
      speed = -15f;
      distance = transform.position.x - 3;
      Debug.Log("left");
      Debug.Log(speed);
    }

    if(Input.GetKeyDown("right")) {
      
      speed = 15f;
      distance = transform.position.x + 3;
      Debug.Log("right");
      Debug.Log(speed);
    }

    Vector2 position = transform.position;
    position = new Vector2(position.x + speed * Time.deltaTime, position.y);
    
    transform.position = position;

    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1 ));
    
    if(transform.position.x > max.x || position.x >= distance) {
      Destroy(gameObject);
    }
	}

  void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "rat") {
      Destroy(col.gameObject);
		}
  }
}