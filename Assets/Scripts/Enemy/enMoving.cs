//PlayerAnimation
//By: Lex King
//Player Animations
// ==================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enMoving : MonoBehaviour
{
    public GameObject target;
    public bool attacking;
    public float attackTime;
    public float coolDown;
    public bool isMoving;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
                              
    }

//End
}
