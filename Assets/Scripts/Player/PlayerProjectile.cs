//PlayerAttack
//By: Rivers
//
//
//=============//


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject BananaBullet;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instBananaBullet = Instantiate(BananaBullet, transform.position, Quaternion.identity);
            Rigidbody2D instBananaBulletRB = instBananaBullet.GetComponent<Rigidbody2D>();

            instBananaBulletRB.AddForce(Vector3.forward * speed);
            Destroy(instBananaBullet, 2f);
        }
    }
}
