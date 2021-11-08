using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public float MovementSpeed = 3;
    public float JumpForce = 3;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f)
        {
            _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
