using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float health = 100f;

    public GameObject deathEffect;

    public void takeDamage(float dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        //Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
