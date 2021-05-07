//PlayerMovement
//By: Lex King
//Basic Player Movement, noted.
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    //Adjust "Player" to be your custom sprite name
    SpriteRenderer Player;

    public float speed;
    public int jumpForce;
    public bool isGrounded;
    public LayerMask isGroundedLayer;
    public Transform groundCheck;
    public float groundCheckRadius;

    // Start is called before the first frame update
    // Run GetComponent in the Start(), never Update().
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Player = GetComponent<SpriteRenderer>();

        if (!rb)
        {
            Debug.Log("Rigidbody2D does not exist");
        }
        if (!anim)
        {
            Debug.Log("Animation does not exist");
        }
        if (!Player)
        {
            Debug.Log("Player does not exist");
        }

        if (speed <= 0)
        {
            speed = 5.0f;
        }
        if (jumpForce <= 0)
        {
            jumpForce = 320;
        }
        if (groundCheckRadius <= 0)
        {
            groundCheckRadius = 0.2f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, isGroundedLayer);

        //Adjust Time.deltaTime * 4, 0, 0 for (X)speed, (Y)jump height, (Z)fall speeds X , Y, Z
        //transform.Translate(new Vector3(horizontalInput * Time.deltaTime * 4, 0, 0));
        //Debug line, not necessarily needed
        Debug.Log(horizontalInput);

        if (Input.GetButtonDown("Jump"))
        {
            //Adjust Time.deltaTime for JUMP height or adjust multiplier below
            rb.AddForce(Vector3.up * jumpForce);
            //Makes jumps act more consistantly
            rb.velocity = Vector2.zero;
        }

        //Jump velocity adjustment as well, adjust if you know what to do.
        Vector2 moveDirection = new Vector2(horizontalInput * speed, rb.velocity.y);
        rb.velocity = moveDirection;

        //Math concepts you can introduce to scripts to 
        anim.SetFloat("speed", Mathf.Abs(horizontalInput));
        anim.SetBool("isGrounded", isGrounded);

        //Flip character on left/rights
        if (Player.flipX && horizontalInput > 0 || !Player.flipX && horizontalInput < 0)
        Player.flipX = !Player.flipX;
        //transform.Rotate(0f, 180f, 0f);

    }
    void Walking()
    {
        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.A)))
            anim.SetBool("isWalking", Player.flipX);
            anim.Play("run");
    }
    /*
    void FirePoints()
    {
        FirePoint.flipX = !FirePoint.flipX;
        transform.Rotate(0f, 180f, 0f);
    }
    */
}
