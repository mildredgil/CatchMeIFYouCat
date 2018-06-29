using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToStory : MonoBehaviour
{

    public void ChangeTStory(string scene)
    {
        SceneManager.LoadScene("About");
    }
}