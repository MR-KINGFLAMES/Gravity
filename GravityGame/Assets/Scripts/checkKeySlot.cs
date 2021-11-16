using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkKeySlot : MonoBehaviour
{

    public keySlot keyIsSlotted;
    // Start is called before the first frame update
    void Start()
    {

        GameObject g = GameObject.FindGameObjectWithTag("slot");
        keyIsSlotted = g.GetComponent<keySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (keyIsSlotted.keySlotted)
        {
            //change sprite.
        }
    }
}
