using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BirdTurret : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public Projectile projectilePrefab;
    public Transform Player;
    public SpriteRenderer EnemyProjectile;

    Animator anim;

    public float bulletImpact;
    public float seeRange;
    public float fireRate;
    public int health;

    float timeSinceLastFire = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if (bulletImpact <= 0)
        {
            bulletImpact = 1.0f;
        }

        if (fireRate <= 0)
        {
            fireRate = 1.0f;
        }

        if (health <= 0)
        {
            health = 1;
        }

        if (seeRange <= 0)
        {
            seeRange = 3;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("isActive", true);
        }
    }

    private void Update()
    {
        if (seeRange >= 3)
        {
            Fire();
            //FireProjectile();
            ReturnToIdle();
        }
    }
    public void Fire()
    {
        if (transform.position.x < Player.position.x)
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            temp.speed = bulletImpact;
        }

        if (transform.position.x > Player.position.x)
        {
            Projectile temp = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            temp.speed = -bulletImpact;
        }
    }
    /*
    void FireProjectile()
    {
        if (EnemyProjectile.flipX)
        {
            Projectile projectileInstance = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectileInstance.speed = -bulletImpact;
        }
        else
        {
            Projectile projectileInstance = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectileInstance.speed = bulletImpact;
        }
    }
    */
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
                Destroy(gameObject.transform.parent.gameObject);
            }
        }
    }
}
