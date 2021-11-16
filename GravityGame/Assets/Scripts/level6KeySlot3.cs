﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6KeySlot3 : MonoBehaviour
{  
    // Start is called before the first frame update
    private bool isInside = false;
    private bool keySlotted = false;
    public GameObject wall;
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
                wall.SetActive(false);
                Destroy(gameObject);
                keySlotted = true;
            }

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "slot2")
        {
            Debug.Log("Its inside");
            isInside = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "slot2")
        {
            Debug.Log("Its no longer inside");
            isInside = false;
        }
    }
}
