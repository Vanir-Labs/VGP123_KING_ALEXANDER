//PlayerProjectile
//By: Lex King
// 
// 
// ==================================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class PlayerProjectile : MonoBehaviour
{                   //Change all "BananaBullet" to customized projectile 
//    public GameObject BananaBullet;
    public GameObject bullet;
    public float speed = 10f;
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    //Instantiate bullets with RB.2D
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
//            GameObject instBananaBullet = Instantiate(BananaBullet, transform.position, Quaternion.identity);
//            Rigidbody2D instBananaBulletRB = instBananaBullet.GetComponent<Rigidbody2D>();

//            instBananaBulletRB.AddForce(Vector3.forward * speed);
            //Destroy projectile after (default 2f = 2 sec) 
//            Destroy(instBananaBullet, 2f);
        GameObject ball = Instantiate(bullet, transform.position, transform.rotation);

        }
        {
            //Supposed to be changing projectile left / right
/*
            if (Input.GetKeyDown(KeyCode.A))
            {
                FirePoint.transform.Rotate(-90, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                FirePoint.transform.Rotate(90, 0, 0);
            }
*/
        }
        //Shooting action           Adjust Mouse0 to custom key
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

    }

    //Shooting projectile
    void Shoot()
    {
//        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);

        var Bullet = (GameObject)Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        // Add velocity to the bullet
        Bullet.GetComponent<Rigidbody2D>().velocity = Bullet.transform.forward * 6;
        // Destroy the bullet after 2 seconds
        Destroy(Bullet, 3.0f);
//        Destroy(GameObject.FindGameObjectsWithTag("Projectile"), 2.0f);
    }
}
