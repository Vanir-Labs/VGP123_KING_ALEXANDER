//enemyHealth
//By: Lex King
//Basic Player Health system.
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float PlHealth = 10;
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        PlHealth -= damage;
        if (PlHealth <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        anima.SetTrigger("die");
    }
}
