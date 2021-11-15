using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform pointD;
    [SerializeField] private Transform pointABCD;
    public GameObject Chainsaw;
    public GameObject otherChainsaw;
    public float interpolateAmount;
    bool whoIsVisible = false;
    void Update()
    {
        interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;

       /*
        pointAB.position = Vector3.Lerp(pointA.position, pointB.position, interpolateAmount);
        pointBC.position = Vector3.Lerp(pointB.position, pointC.position, interpolateAmount);
        pointCD.position = Vector3.Lerp(pointC.position, pointD.position, interpolateAmount);

        pointAB_BC.position = Vector3.Lerp(pointAB.position, pointBC.position, interpolateAmount);
        pointBC_CD.position = Vector3.Lerp(pointBC.position, pointCD.position, interpolateAmount);

        pointABCD.position = Vector3.Lerp(pointAB_BC.position, pointBC_CD.position, interpolateAmount);
        */
        pointABCD.position = CubicLerp(pointA.position, pointB.position, pointC.position, pointD.position, interpolateAmount);
<<<<<<< HEAD

        if (whoIsVisible)
        {
            Debug.Log("chainsaw isactive");
            Chainsaw.SetActive(true);
            otherChainsaw.SetActive(false);
        }
        if(!whoIsVisible)
        {

            Debug.Log("chainsaw is inactive");
            Chainsaw.SetActive(false);
            otherChainsaw.SetActive(true);
=======
        if (interpolateAmount == 1)
        {
            otherChainsaw.SetActive(true);
            gameObject.SetActive(false);
>>>>>>> a41010b76c9589221481d4da31fcee5c4ee055dc
        }
    }
    private Vector3 QuadraticLerp(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        Vector3 ab = Vector3.Lerp(a, b, t);
        Vector3 bc = Vector3.Lerp(b, c, t);

        return Vector3.Lerp(ab, bc, interpolateAmount);
    }

    private Vector3 CubicLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
    {
        Vector3 ab_bc = QuadraticLerp(a, b, c, t);
        Vector3 bc_cd = QuadraticLerp(b, c, d, t);

        return Vector3.Lerp(ab_bc, bc_cd, interpolateAmount);
    }
   /* void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "chainsawControl"))
        {
<<<<<<< HEAD
            if (whoIsVisible)
            {
                whoIsVisible = false;

            }
            if (!whoIsVisible)
            {
            }
            
=======
            otherChainsaw.SetActive(true);
            gameObject.SetActive(false);
>>>>>>> a41010b76c9589221481d4da31fcee5c4ee055dc
        }
    }*/
}
