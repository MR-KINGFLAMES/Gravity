using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{


    void Update()
    {

        Vector3 MousePos = Input.mousePosition;
        Vector3 gunpos = Camera.main.WorldToScreenPoint(transform.position);
        MousePos.x = MousePos.x - gunpos.x;
        MousePos.y = MousePos.y - gunpos.y;
        float gunangle = Mathf.Atan2(MousePos.y, MousePos.x) * Mathf.Rad2Deg;
        
        if(Camera.main.WorldToScreenPoint(Input.mousePosition).x<transform.position.x)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
        }

    }
}
