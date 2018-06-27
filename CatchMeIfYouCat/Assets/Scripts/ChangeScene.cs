using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void changeScene(string scene) {
    SceneManager.LoadScene(scene);
  }

  public static void changeScene2(string scene) {
    SceneManager.LoadScene(scene);
  }
}
