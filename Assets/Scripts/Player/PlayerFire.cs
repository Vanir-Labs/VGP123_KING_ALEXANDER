using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerFire : MonoBehaviour
{
    SpriteRenderer Player;
    Animator anim;

    public Transform spawnPointLeft;
    public Transform spawnPointRight;

    public Projectile Bullet;
    public float projectileSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        if (projectileSpeed <= 0)
            projectileSpeed = 7.0f;

        if (!spawnPointLeft || !spawnPointRight || !Bullet)
            Debug.Log("Unity Inspector Values Not Set");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            anim.SetBool("isShooting", true);
        }
    }

    void FireProjectile()
    {
        if (Player.flipX)
        {
            Projectile projectileInstance = Instantiate(Bullet, spawnPointLeft.position, spawnPointLeft.rotation);
            projectileInstance.speed = -projectileSpeed;
        }
        else
        {
            Projectile projectileInstance = Instantiate(Bullet, spawnPointRight.position, spawnPointRight.rotation);
            projectileInstance.speed = projectileSpeed;
        }
    }

    void ResetFire()
    {
        anim.SetBool("isShooting", false);
    }
}
