//PlayerAttack
//By: Rivers
//Attack and damage -10 for each hit.
//Additional damages in progress
//=============//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject target;
    public float attackTime;
    public float coolDown;

    // Use this for initialization
    void Start()
    {
        attackTime = 0;
        //Delay between attacks
        coolDown = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackTime > 0)
            attackTime -= Time.deltaTime;

        if (attackTime < 0)
            attackTime = 0;
        //button pressed to activate attack (Mouse0 default)
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (attackTime == 0)
            {
                Attack();
                attackTime = coolDown;
            }
        }
    }

    private void Attack()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);
        Debug.Log(direction);

        //Distance to target
        if (distance < 2.5f)
        {
            if (direction > 0)
            {
                //EnemyHP deduction, WIP
                //EnemyHealth enhp = (EnemyHealth)target.GetComponent("EnemyHealth");
               // enhp.EnHealth(-10);
            }
        }
    }
}


