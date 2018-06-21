using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToHowToPlay : MonoBehaviour
{

    public void ChangeToHTP(string scene)
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
