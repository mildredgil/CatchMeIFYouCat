using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
float speed;
float distance;
	// Use this for initialization
	void Start () {
		 if (GameObject.Find("cat").GetComponent<cat>().isLeft) {
      speed = -15f;
      
    } else {
      speed = 15f;
      
    }
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
      Destroy(gameObject, 0.1f);
    }
    
	}

  void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "rat") {
      Destroy(col.gameObject);
		}
  }
}