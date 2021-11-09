using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroyed : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    // Update is called once per frame

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bulletStopper")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "player")
        {

        }
    }
}
