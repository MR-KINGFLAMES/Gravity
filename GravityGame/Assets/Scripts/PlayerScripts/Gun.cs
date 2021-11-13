using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Transform grabDet;
    public Transform boxHold;
    public float rayDist;
    
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 GunPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if(GunPos.x<transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }

        RaycastHit2D grabCheck = Physics2D.Raycast(grabDet.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Box")
        {
            if (Input.GetMouseButtonDown(1))
            {
                grabCheck.collider.gameObject.transform.parent = boxHold;
                grabCheck.collider.gameObject.transform.position = boxHold.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
        

    }
}
