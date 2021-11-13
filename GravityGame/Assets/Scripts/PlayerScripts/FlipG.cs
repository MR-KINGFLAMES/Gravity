using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipG : MonoBehaviour
{
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
           _rb.gravityScale *= -1;
        }
    }
}
