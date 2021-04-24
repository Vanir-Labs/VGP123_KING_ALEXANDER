//enemyHealth
//By: Lex King
//Basic Enemy Health system.
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class EnemyHealth : MonoBehaviour
{
    public float EnHealth = 10;
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        if (EnHealth <= 0)
        {
            return;
        }
        EnHealth -= damage;
        if (EnHealth <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        anima.SetTrigger("die");
    }
}
