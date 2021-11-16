using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smashCrate : MonoBehaviour
{
    public GameObject key;
    public GameObject o2;
    public GameObject tempKey;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        o2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "heavyObject")
        {
            key.SetActive(true);
            tempKey.SetActive(false);
            o2.SetActive(true);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
