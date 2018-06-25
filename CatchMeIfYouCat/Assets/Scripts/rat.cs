using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat : MonoBehaviour {

  public float jump;

	// Use this for initialization
	void Start () {
		jump = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void jumping() {
    transform.Translate(0f,jump + 0f,0f);
  }
}
