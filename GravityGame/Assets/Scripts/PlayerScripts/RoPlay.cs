using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoPlay : MonoBehaviour
{
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Mouse2))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 180f));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        }


    }
}
