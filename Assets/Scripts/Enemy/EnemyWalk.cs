using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(Animator))]
public class EnemyWalk : MonoBehaviour
{
    Rigidbody2D rb; //Sprite to give RB 2D to
    SpriteRenderer spr;
    Animator anim;

    public int health;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        if (speed <= 0)
        {
            speed = 5.0f;
        }
        if (health <= 0)
        {
            health = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.GetBool("isDie") && !anim.GetBool("isHit")); //Animations when die and when hit
            {
                if (spr.flipX)
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
                else
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
            }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EdgeMarker")
        {
            spr.flipX = !spr.flipX;
        }
    }


    //End
}
