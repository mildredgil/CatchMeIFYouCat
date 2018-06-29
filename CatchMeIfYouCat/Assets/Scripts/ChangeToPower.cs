using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeToPower : MonoBehaviour
{

    public void ChangePower(string scene)
    {
        SceneManager.LoadScene("Power");
    }
}