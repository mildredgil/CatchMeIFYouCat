using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratShoot : MonoBehaviour {

  float speed;
  int direction;

  // Use this for initialization
  void Start () {
    /*direction = Random.Range(-1, 1);
    if(direction == 0) 
      direction = -1;
    else*/
    direction = 1;
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
    }    
	}

  void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "cat") {
      Debug.Log("cat -1!");
      GameManager.checkIfLoose();
      GameManager.health--;
		}
    if(col.gameObject.tag != "rat")
      Destroy(gameObject);
  }
}
