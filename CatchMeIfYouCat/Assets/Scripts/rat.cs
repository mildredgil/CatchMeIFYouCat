using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat : MonoBehaviour {

  public float jump;
  public GameObject bulletPos;
  public GameObject ratBullet;

  static int direction;
	// Use this for initialization
	void Start () {
		jump = 0f;
    InvokeRepeating("jumping", 2.0f, 1.0f);
    InvokeRepeating("bullet", 4.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		jump = 1f;
	}

  void jumping() {
    transform.Translate(0f,jump + 0f,0f);
    jump = 0;
  }

  void bullet() {
    GameObject bullet = (GameObject)Instantiate (ratBullet);

    direction = Random.Range(-1, 1);
    if(direction == 0) {
      transform.rotation = Quaternion.Euler(0, 0, 0); //change direction
      bullet.AddComponent<ratShootLeft>();
    } else {
      transform.rotation = Quaternion.Euler(0, 180, 0); //change direction
      bullet.AddComponent<ratShoot>();
    }

    bullet.transform.position = bulletPos.transform.position;
  }
}
