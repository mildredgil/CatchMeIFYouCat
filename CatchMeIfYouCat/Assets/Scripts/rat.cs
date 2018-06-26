using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat : MonoBehaviour {

  public float jump;
  public GameObject bulletPos;
  public GameObject ratBullet;
	// Use this for initialization
	void Start () {
		jump = 0f;
    InvokeRepeating("jumping", 2.0f, 1.0f);
    InvokeRepeating("bullet", 5.0f, .5f);
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
    GameObject bulletPosition = (GameObject)Instantiate (ratBullet);
    bulletPosition.transform.position = bulletPos.transform.position;        
  }
}
