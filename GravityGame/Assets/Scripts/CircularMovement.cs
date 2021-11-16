using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(1, 0);

    public gunCooldown canUseGun;
    private bool isFrozen = false;
    private bool canFreeze = false;
    private bool countingDown = false;
    private float timer = 5.0f;

    [Range(0, 5)]
    public float RotateSpeed = 2.4f;
    [Range(0, 5)]
    public float Radius = 1f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = transform.position;
        GameObject g = GameObject.FindGameObjectWithTag("manager");
        canUseGun = g.GetComponent<gunCooldown>();
    }

    private void Update()
    {
        if (countingDown)
        {
            if (timer >= 0)
            {

                timer -= Time.deltaTime;
            }
            if (timer < 0)
            {
                Debug.Log("Time ran out");
                timer = 5.0f;

                RotateSpeed = 2.4f;
                canUseGun.canUseGunHead = true;
                countingDown = false;
                isFrozen = false;
            }
        }
        if (!isFrozen)
        {
            _centre += Velocity * Time.deltaTime;

            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;

            transform.position = _centre + offset;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (canUseGun.canUseGunHead == true)
            {
                Debug.Log("canuse gunhead is true it");
                if (canFreeze)
                {
                    RotateSpeed = 1f;
                    Debug.Log("You froze it");
                    isFrozen = true;
                    canUseGun.canUseGunHead = false;
                    countingDown = true;
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_centre, 0.1f);
        Gizmos.DrawLine(_centre, transform.position);
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