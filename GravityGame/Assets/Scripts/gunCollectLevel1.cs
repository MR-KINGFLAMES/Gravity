using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunCollectLevel1 : MonoBehaviour
{
    public GameObject arm;
    bool armVisible;
    // Start is called before the first frame update
    void Start()
    {
        armVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (armVisible)
        {
            arm.SetActive(true);
        }
        if (!armVisible)
        {
            arm.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "arm")
        {
            armVisible = true;
            collision.gameObject.SetActive(false);
        }
    }
}
