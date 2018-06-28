using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

  //change scene with a button
	public void changeScene(string scene) {
    SceneManager.LoadScene(scene);
  }

  //change scene in a script
  public static void changeScene2(string scene) {
    SceneManager.LoadScene(scene);
  }
}
