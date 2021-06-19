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
        if (!anim.GetBool("isDead") && !anim.GetBool("isHit")); //Animations when die and when hit
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

        /*
            switch (direction)
            {
                case -1:
                    // Moving Left
                    if (transform.position.x > minDist)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else
                    {
                        direction = 1;
                    }
                    break;
                case 1:
                    //Moving Right
                    if (transform.position.x < maxDist)
                    {
                        GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                    }
                    else
                    {
                        direction = -1;
                    }
                    break;
            }
        */
        /*
        if (!anim.GetBool("isDead") && !anim.GetBool("isHit"));
                if (speed < 0)
                {
                    spr.gameObject.tag == "enMoving");
                }
        */
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
