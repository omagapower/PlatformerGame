using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
}
