using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public float currentSpeed = 3;
    public float JumpForce = 3;
    public float runSpeed;
    public float walkSpeed;

    private Rigidbody2D _rb;
    bool isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {


        walkSpeed = currentSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            walkSpeed = runSpeed;
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * walkSpeed;

        //if (!Mathf.Approximately(0, movement))
        //    transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;



        if (isGrounded == true)
        {
            if (Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f)
            {
                _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

            }
        }
        else if (isGrounded == false)
        {
            if (Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f)
            {
                _rb.AddForce(new Vector2(0, -JumpForce), ForceMode2D.Impulse);

            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Floor")
        {
            Debug.Log("Touched Floor");
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}

