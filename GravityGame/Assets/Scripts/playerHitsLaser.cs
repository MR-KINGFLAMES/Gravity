using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitsLaser : MonoBehaviour
{
    public Transform firePoint;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            gameObject.transform.position = firePoint.position;
        }
    }
}
