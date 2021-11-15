using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserShoot1 : MonoBehaviour
{
    public Transform firePoint;
    float time = 1.5f;
    public float timeRemaining;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = time;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            shoot();
            timeRemaining = time;
        }
    }
    void shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
