using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRats : MonoBehaviour {

  public GameObject ratEnemie;
  public GameObject[] ratPositions;

  private GameObject[] ratEnemies;
  
  public void createRat() {
    ratEnemies = new GameObject[6];

    for(int i = 0; i < 6; i++) {
      ratEnemies[i]  = Instantiate(ratEnemie) as GameObject;
      ratEnemies[i].transform.position = ratPositions[i].transform.position;      
    }
  }
	// Use this for initialization
	void Start () {
    createRat();
    InvokeRepeating("checkUnactiveRat", 10, 10);
	}
	
	// Update is called once per frame
	void Update () {
    
	}

  void checkUnactiveRat() {
    for(int i = 0; i < 6; i++) {
      if( !ratEnemies[i].activeSelf )
        ratEnemies[i].SetActive(true);
        ratEnemies[i].transform.GetChild(0).gameObject.SetActive(true);
    }
  }
}
