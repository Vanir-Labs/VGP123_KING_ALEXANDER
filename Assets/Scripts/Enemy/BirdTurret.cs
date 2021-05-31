// ==================================================
//
//
//
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyTurret : MonoBehaviour
{
    public Transform projectileSpawnPointRight;
    public Transform projectileSpawnPointLeft;
    public Projectile projectilePrefab;

    public float projectileForce;

    public float projectileFireRate;
    public float turretFireDistance;
    float timeSinceLastFire = 0.0f;
    bool canFire;
    public int health;

    Animator anim;
    SpriteRenderer sr;

    GameObject player;

    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        if (projectileForce <= 0)
        {
            projectileForce = 7.0f;
        }

        if (projectileFireRate <= 0)
        {
            projectileFireRate = 2.0f;
        }

        if (health <= 0)
        {
            health = 5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (player.transform.position.x < transform.position.x)
            {
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
            }

            float distance = Vector2.Distance(transform.position, player.transform.position);

            if (distance <= turretFireDistance)
                canFire = true;
            else
                canFire = false;

            if (Time.time >= timeSinceLastFire + projectileFireRate)
            {
                if (canFire)
                {
                    anim.SetBool("Fire", true);
                    timeSinceLastFire = Time.time;
                }
            }
        }
        else
        {
            if (GameManager.instance.playerInstance)
                player = GameManager.instance.playerInstance;
        }
    }

    public void Fire()
    {
        if (sr.flipX)
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPointLeft.position, projectileSpawnPointLeft.rotation);
            temp.speed = -projectileForce;
        }
        else
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPointRight.position, projectileSpawnPointRight.rotation);
            temp.speed = projectileForce;
        }
    }

    public void ReturnToIdle()
    {
        anim.SetBool("isShooting", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health--;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
// End
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BirdTurret : MonoBehaviour
{
    public Transform projectileSpawnPointRight;
    public Transform projectileSpawnPointLeft;
    public Projectile projectilePrefab;

    public float projectileForce;

    public float projectileFireRate;
    public float turretFireDistance;
    float timeSinceLastFire = 0.0f;
    bool isShooting;
    public int health;

    Animator anim;
    SpriteRenderer sr;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        if (projectileForce <= 0)
        {
            projectileForce = 7.0f;
        }

        if (projectileFireRate <= 0)
        {
            projectileFireRate = 2.0f;
        }

        if (health <= 0)
        {
            health = 5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            if (Player.transform.position.x < transform.position.x)
            {
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
            }

            float distance = Vector2.Distance(transform.position, Player.transform.position);

            if (distance <= turretFireDistance)
                isShooting = true;
            else
                isShooting = false;

                if (Time.time >= timeSinceLastFire + projectileFireRate)
            {
                if (isShooting)
                {
                    anim.SetBool("Fire", true);
                    timeSinceLastFire = Time.time;
                }
            }
        }
        else
        {
            if (GameManager.instance.playerInstance)
                Player = GameManager.instance.playerInstance;
        }
    }

    public void Fire()
    {
        if (sr.flipX)
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPointLeft.position, projectileSpawnPointLeft.rotation);
            temp.speed = -projectileForce;
        }
        else
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPointRight.position, projectileSpawnPointRight.rotation);
            temp.speed = projectileForce;
        }
    }

    public void ReturnToIdle()
    {
        anim.SetBool("Fire", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerProjectile")
        {
            health--;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
