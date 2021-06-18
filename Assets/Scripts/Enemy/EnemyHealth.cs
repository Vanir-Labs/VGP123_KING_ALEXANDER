//enemyHealth
//By: Lex King
//Basic Enemy Health system.
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class EnemyHealth : MonoBehaviour
{
    public float enHealth = 3;
    public Rigidbody2D enSprite;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        enHealth -= damage;
        if (enHealth <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        anim.SetTrigger("enDie");
    }
}
