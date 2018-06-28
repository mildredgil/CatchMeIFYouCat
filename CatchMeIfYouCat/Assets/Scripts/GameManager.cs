using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

  public static int timeLeft;
  public static int rats;

  public static int health;
	// Use this for initialization
	void Start () {
		timeLeft = 90;
    rats = 0;
    health = 11;
    InvokeRepeating("count", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
    
	}

  void count() {
    if(timeLeft > 0)
      timeLeft--;
    else
      ChangeScene.changeScene2("looser");
  }

  public static void checkIfWin() {
    if(rats == 25) {
      ChangeScene.changeScene2("wiiner");
    }
  }

  public static void checkIfLoose() {
    if(health == 0) {
      ChangeScene.changeScene2("looser");
    }
  }
}
