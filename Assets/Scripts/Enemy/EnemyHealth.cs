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
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        if (enHealth <= 0)
        {
            return;
        }
        enHealth -= damage;
        if (enHealth <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        anima.SetTrigger("enDie");
    }
}
