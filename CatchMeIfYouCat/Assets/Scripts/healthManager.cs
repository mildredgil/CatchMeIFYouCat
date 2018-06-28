using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour {

  public Sprite[] healthBars;  

	// Use this for initialization
	void Start () {
    this.gameObject.GetComponent<Image>().sprite = healthBars[0]; 
    Debug.Log(this.gameObject.name);
	}

  void Update() {
    updateHealthBar();
  }
	
	// Update is called when the cat is attacked
  public void updateHealthBar() {
    switch(GameManager.health) {
      case 0:
        this.gameObject.GetComponent<Image>().sprite = healthBars[0]; 
      break;
      case 1:
        this.gameObject.GetComponent<Image>().sprite = healthBars[1]; 
      break;
      case 2:
        this.gameObject.GetComponent<Image>().sprite = healthBars[2]; 
      break;
      case 3:
        this.gameObject.GetComponent<Image>().sprite = healthBars[3]; 
      break;
      case 4:
        this.gameObject.GetComponent<Image>().sprite = healthBars[4]; 
      break;
      case 5:
        this.gameObject.GetComponent<Image>().sprite = healthBars[5]; 
      break;
      case 6:
        this.gameObject.GetComponent<Image>().sprite = healthBars[6]; 
      break;
      case 7:
        this.gameObject.GetComponent<Image>().sprite = healthBars[7]; 
      break;
      case 8:
        this.gameObject.GetComponent<Image>().sprite = healthBars[8]; 
      break;
      case 9:     
        this.gameObject.GetComponent<Image>().sprite = healthBars[9]; 
      break;
      case 10:
        this.gameObject.GetComponent<Image>().sprite = healthBars[10]; 
      break;
      case 11:
        this.gameObject.GetComponent<Image>().sprite = healthBars[11]; 
      break;
    }
  }
}
