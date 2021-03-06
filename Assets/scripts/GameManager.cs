using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{



    bool gameEnded = false;
    public float delay = 1f;
    string[] lev = {"Level2", "Level3" };
    public GameObject completeUI;
    public GameManager manager;
    // Start is called before the first frame update

    private void Start()
    {
        gameEnded = false;
    }
    public void gameOver()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Restart();
        }
        
    }

    public void nextLevel()
    {
        if (gameEnded == false)
        {
            completeUI.SetActive(true);
            gameEnded = true;
            Debug.Log("next level");
            Invoke("win", delay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}