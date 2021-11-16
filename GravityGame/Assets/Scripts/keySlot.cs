using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySlot : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isInside = false;
    public bool keySlotted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isInside)
            {
                Debug.Log("You landed it inside");
                keySlotted = true;
                gameObject.SetActive(false);
            }

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "slot")
        {
            Debug.Log("Its inside");
            isInside = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "slot")
        {
            Debug.Log("Its no longer inside");
            isInside = false;
        }
    }
}
