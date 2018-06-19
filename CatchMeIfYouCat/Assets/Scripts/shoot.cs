using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

  float speed;
	// Use this for initialization
	void Start () {
		speed = 8f;
	}
	
	// Update is called once per frame
	void Update () {

    if(Input.GetKeyDown("space")) {
      shootBullet();
    }
	}

  void shootBullet() {
    Vector2 position = transform.position;
    position = new Vector2(position.x + speed * Time.deltaTime, position.y);
    //Debug.Log(position.y);
    transform.position = position;

    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1));

    if(transform.position.x > max.x) {
      Destroy(gameObject);
    }

    //yield return new WaitForSeconds(5);
    Destroy(gameObject);
  }
}

