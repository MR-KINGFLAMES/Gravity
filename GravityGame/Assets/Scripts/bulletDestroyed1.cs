using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroyed1 : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    // Update is called once per frame

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }
    void Update()
    {
        transform.Translate(-Vector3.right * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Floor")
        {

            Destroy(gameObject);
        }
    }
}
