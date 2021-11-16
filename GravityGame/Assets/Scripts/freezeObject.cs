using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeObject : MonoBehaviour
{

    // Start is called before the first frame update
    private bool canFreeze = false;
    private bool isFrozen = false;
    private bool countingDown = false;
    private float timer = 5.0f;
    public gunCooldown canUseGun;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        GameObject g = GameObject.FindGameObjectWithTag("manager");
        canUseGun = g.GetComponent<gunCooldown>();

    }

    void Update()
    {
        if (countingDown)
        {
            if(timer >= 0)
            {

                timer -= Time.deltaTime;
            }
            if(timer < 0)
            {
                Debug.Log("Time ran out");
                timer = 5.0f;

                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                canUseGun.canUseGunHead = true;
                countingDown = false;
                isFrozen = false;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (canUseGun.canUseGunHead == true)
            {
                if (canFreeze)
                {
                    gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                    Debug.Log("You froze it");
                    isFrozen = true;
                    canUseGun.canUseGunHead = false;
                    countingDown = true;
                }
            }
        }
        if (gameObject.tag == "Box")
        {
            if (Input.GetMouseButtonDown(2))
            {
                if (!isFrozen)
                {
                    _rb.gravityScale *= -1;
                }

            }
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log("You entered this object");
        canFreeze = true;
    }

    private void OnMouseExit()
    {
        Debug.Log("You left this object");
        canFreeze = false;
    }
}
