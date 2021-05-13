//PlayerAttack
//By: Lex King
// 
// 
// ==================================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{                   //Change all "BananaBullet" to customized projectile 
//    public GameObject BananaBullet;
    public float speed = 10f;
    public Transform FirePoint;
    public GameObject bulletPrefab;

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
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
