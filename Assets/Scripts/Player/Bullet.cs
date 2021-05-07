using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 6f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
    void  OnControllerColliderHit()
    {
        void OnCollisionEnter2D(Collision2D other)
        {
            Destroy(other.gameObject);
        }
    }

}
