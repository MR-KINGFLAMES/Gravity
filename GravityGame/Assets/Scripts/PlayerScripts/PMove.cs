using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public float currentSpeed = 3;
    public float JumpForce = 3;
    public float runSpeed;
    public float walkSpeed;

    public O2Bar o2bar;
    public float maxO2 = 300;
    public float currentO2;

    private Rigidbody2D _rb;
    bool isGrounded;

    public Transform spawn;

    void Start()
    {
        currentO2 = maxO2;
        o2bar.SetO2(currentO2);

        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        o2bar.SetO2(currentO2);

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
        StartCoroutine(DamageOverTimeCoroutine(0, 0));
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

        if (col.gameObject.tag == "Saw")
        {
            gameObject.transform.position = spawn.position;
            TakeDamage(10);
            
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {

            TakeDamage(10);
            Destroy(collision.gameObject);
        }

    }

  
    void TakeDamage(int damage)
    {
        currentO2 -= damage;
    }

    IEnumerator DamageOverTimeCoroutine(float damageAmount, float duration)
    {
        float amountDamage = 0;
        duration = 10000;
        damageAmount = 1;
        float damagePerLoop = damageAmount / duration;

        while (amountDamage < damageAmount)
        {
            currentO2 -= damagePerLoop;
            Debug.Log("Taking Damage Right Now");
            amountDamage += damagePerLoop;
            yield return new WaitForSeconds(1f);
        }
    }


}

