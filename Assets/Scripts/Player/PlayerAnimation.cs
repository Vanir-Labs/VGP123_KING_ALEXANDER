//PlayerAnimation
//By: Lex King
//Basic Player attack aniamtions.
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;
    private bool Shoot;
    private float lifetime;

    // Use this for initialization
    void Start()
    {
/*
        {
            if (lifetime <= 0)
            {
                lifetime = 2.0f;
            }
            Destroy(gameObject, lifetime);
        }
*/
    }

    void Animationor()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        {

            if (Input.GetKeyDown(KeyCode.Mouse0) || (Input.GetKeyDown(KeyCode.LeftControl)))
                anim.Play("Shoot");
        }
        {
            if (Input.GetKeyDown(KeyCode.A) && (Input.GetKeyDown(KeyCode.LeftShift)))
                anim.Play("run");
        }
        {
            if (Input.GetKeyDown(KeyCode.D) && (Input.GetKeyDown(KeyCode.LeftShift)))
                anim.Play("run");
        }
        {
            if (Input.GetKeyDown(KeyCode.A))
                anim.Play("walk");
        }
        {
            if (Input.GetKeyDown(KeyCode.D))
                anim.Play("walk");
        }
        {
            if (Input.GetKeyDown(KeyCode.W))
                anim.Play("Jump");
        }
        {
            if (Input.GetKeyDown(KeyCode.Space))
                anim.Play("Jump");
        }
    }

}
