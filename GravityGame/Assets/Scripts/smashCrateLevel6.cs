using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smashCrateLevel6 : MonoBehaviour
{
    public GameObject o2;

    // Start is called before the first frame update
    void Start()
    {
        o2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Saw")
        {
            o2.SetActive(true);
            Destroy(gameObject);
            col.gameObject.SetActive(false);

        }
    }
}

