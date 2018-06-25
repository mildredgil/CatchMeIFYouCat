using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour {
  public GameObject bullet;
  public GameObject Player;
  
  public float moveSpeed;
  public float jump;
  double min;
  double max;
  bool isGrounded;
  public bool isLeft;
	// Use this for initialization
	void Start () {
		moveSpeed = 8f;
    jump = 0;
    isGrounded = false;
    Vector2 maxVal = Camera.main.ViewportToWorldPoint(new Vector2 (1 , 1 ));
    Vector2 minVal = Camera.main.ViewportToWorldPoint(new Vector2 (0 , 0 ));
    min = minVal.x;
    max = maxVal.x;
	}
	
	// Update is called once per frame
	void Update () {    
    move();
    jumping();
    shoot();
    directionFlag();
	}

  //move the cat left and right
  void move() {
    if(isLeft)
      moveSpeed = -8f;
    else
      moveSpeed = 8f;

    if(transform.position.x <= min)
	    transform.Translate(moveSpeed*(Input.GetAxis("Horizontal") + 1)*Time.deltaTime,jump + 0f,0f);
    else if(transform.position.x >= max)
      transform.Translate(moveSpeed*(Input.GetAxis("Horizontal") - 1)*Time.deltaTime,jump + 0f,0f);
    else
      transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,jump + 0f,0f);
  }

  //make the cat shoot
  void shoot() {
    if(Input.GetKeyDown("space")) {
      GameObject bulletpos = (GameObject)Instantiate (Player);
      bulletpos.transform.position = bullet.transform.position;
    }
  }

  void directionFlag(){
    if(Input.GetKeyDown("left")) {
      isLeft = true;
      transform.rotation = Quaternion.Euler(0, 0, 180); //change direction
    }
    if(Input.GetKeyDown("right")) {
      isLeft = false; 
      transform.rotation = Quaternion.Euler(0, 0, 0); //change direction
    }
  }

  //jump
  void jumping() {
    if(Input.GetKeyDown("up") && isGrounded) {
      jump = 2;
      isGrounded = false;
      transform.rotation = Quaternion.Euler(0, 0, 0);
    } else {
      jump = 0;
    } 
  }

//check if the cat is on the floor
  void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "floor" && isGrounded == false) {
      if(isLeft) {
        isGrounded = true;
      } else {
        isGrounded = true;
      }      
		}
  }
}
  
