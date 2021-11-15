using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeObject : MonoBehaviour
{

    // Start is called before the first frame update
    private bool canFreeze = false;
    private bool isFrozen = false;
    
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canFreeze)
            {
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                Debug.Log("You froze it");
                isFrozen = true;
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
