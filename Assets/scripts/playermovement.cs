using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playermovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator animator;
    float jmp = 7f;
    public bool isjump;
    public float pmove;
    public bool crouch;
    public float movespd = 2f;

    public bool isGrounded = false;

    public Inventory inventory;

    // Start is called before the first frame update
    void Awake()
    {
        inventory = new Inventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("crouch", true);
        }

        if (Input.GetButtonUp("Crouch"))
        {
            animator.SetBool("crouch", false);
        }

        pmove = Input.GetAxis("Horizontal");
        animator.SetFloat("walking", Math.Abs(pmove));
        pmove *= movespd * Time.fixedDeltaTime;
        if (pmove < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3 (0, 180, 0));
        }
        if(pmove>0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        transform.position += new Vector3(pmove, 0f, 0f);
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(pmove, 0f), ForceMode2D.Impulse);
        //rb.velocity.Set(pmove, 0);
        //rb.AddForce(new Vector2(pmove, 0));
        jump();
    }

    void jump()
    {
        if (isGrounded)
        {
            animator.SetBool("jumpdown", false);
            animator.SetBool("isgrounded", isGrounded);
        }

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            animator.SetBool("jumpdown", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jmp), ForceMode2D.Impulse);

        }
    }
}
