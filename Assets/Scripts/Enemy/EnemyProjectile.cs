//enemyHealth
//By: Lex King
//Projectiles for enemies.
//=============//
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    int Rigidbody2D bulletPrefab;
    int bulletSpeed = 5f;
    private int Transform target;

    void OnTriggerEnter(Player : Collider)
    {
        if (Player.CompareTag("Player"))
        {
            target = Player.transform;
            Fire();
        }
    }

    void OnTriggerExit(Player : Collider)
    {
        if (Player.CompareTag("Player"))
        {
            target = null;
            StopCoroutine();
        }
    }

    void Fire()
    {
        while (target != null)
        {
            var nextFire = Time.time + 1;
            while (Time.time < nextFire)
            {
                transform.LookAt(target);
                yield WaitForEndOfFrame();
            }

            var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.velocity = transform.forward * bulletSpeed;
        }
    }
    //End
}

*/
