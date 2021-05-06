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
    // Use this for initialization
    void Start()
    {
    }

    void Animationor()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || (Input.GetKeyDown(KeyCode.LeftControl)))
            anim.Play("isShooting");
    }
}
