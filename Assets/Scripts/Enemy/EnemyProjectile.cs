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
    var bulletPrefab : Rigidbody;
    var bulletSpeed : float = 10;
    private var target : Transform;

    void OnTriggerEnter(otherCollider : Collider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            target = otherCollider.transform;
            Fire();
        }
    }

    void OnTriggerExit(otherCollider : Collider)
    {
        if (otherCollider.CompareTag("Player"))
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
