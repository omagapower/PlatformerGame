using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<playermovement>().isGrounded = true;
        }

        if (collision.collider.tag == "Death")
        {
            FindObjectOfType<GameManager>().gameOver();
            
        }
        else if (collision.collider.tag == "Win")
        {
            FindObjectOfType<GameManager>().nextLevel();

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<playermovement>().isGrounded = false;
        }
    }
}

