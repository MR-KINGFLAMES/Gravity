using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObjGravity : MonoBehaviour
{
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (gameObject.tag == "Box")
        {
            if (Input.GetMouseButtonDown(2))
            {
                //transform.localScale = new Vector2(transform.localScale.x, -transform.localScale.y);
                _rb.gravityScale *= -1;

            }
        }
    }
}
