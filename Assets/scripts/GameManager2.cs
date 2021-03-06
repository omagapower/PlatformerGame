using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{



    bool gameEnded = false;
    public float delay = 0f;
    // Start is called before the first frame update

    private void Start()
    {
        gameEnded = false;
    }
    public void gameOver()
    {
        if (gameEnded == false)
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
            gameEnded = true;
            Debug.Log("next level");
            win();
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void win()
    {
        SceneManager.LoadScene("Level3");
    }
}