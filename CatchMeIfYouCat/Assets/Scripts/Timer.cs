using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

  public Text timer;
	// Use this for initialization
	void Start () {
		timer.text = "2:00";
	}
	
	// Update is called once per frame
	void Update () {
		updateTimer();
	}

  void updateTimer() {
     int time = GameManager.timeLeft;
     int hour = time / 60;
     int minutes = time % 60; 

     if(minutes < 10) {
        timer.text = hour + ":0" + minutes;
     } else {
        timer.text = hour + ":" + minutes;
     }

     
  }
}
