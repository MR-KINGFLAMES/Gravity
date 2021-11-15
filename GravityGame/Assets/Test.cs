﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform pointD;
    [SerializeField] private Transform pointABCD;
    public float interpolateAmount;
    public bool reverse;

    void Update()
    {
        if (!reverse)
        {
            interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;
        }
        else
        {
            interpolateAmount = (interpolateAmount - Time.deltaTime) % 1f;
        }
       /*
        pointAB.position = Vector3.Lerp(pointA.position, pointB.position, interpolateAmount);
        pointBC.position = Vector3.Lerp(pointB.position, pointC.position, interpolateAmount);
        pointCD.position = Vector3.Lerp(pointC.position, pointD.position, interpolateAmount);

        pointAB_BC.position = Vector3.Lerp(pointAB.position, pointBC.position, interpolateAmount);
        pointBC_CD.position = Vector3.Lerp(pointBC.position, pointCD.position, interpolateAmount);

        pointABCD.position = Vector3.Lerp(pointAB_BC.position, pointBC_CD.position, interpolateAmount);
        */
        pointABCD.position = CubicLerp(pointA.position, pointB.position, pointC.position, pointD.position, interpolateAmount);
        if (pointABCD.position == pointD.position)
        {
            reverse = true;
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
}
