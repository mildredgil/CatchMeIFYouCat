using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToIntro : MonoBehaviour
{

    public void ChangeToLevelOne(string scene)
    {
        SceneManager.LoadScene("Level1");
    }
}