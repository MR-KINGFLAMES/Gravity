using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6KeySlot2 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isInside = false;
    private bool keySlotted = false;
    public GameObject wall;
    public GameObject currentSlot;
    public GameObject key2;
    public GameObject wall2;
    public GameObject keyslot2;
    void Start()
    {
        wall2.SetActive(false);
        key2.SetActive(false);
        keyslot2.SetActive(false);
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
                currentSlot.SetActive(false);
                wall2.SetActive(true);
                key2.SetActive(true);
                keyslot2.SetActive(true);
                Destroy(gameObject);
                keySlotted = true;
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
