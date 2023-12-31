using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAlrededorDelSol : MonoBehaviour
{
    public Transform sun;
    public float orbitSpeed = 10.0f;  
    public float distanceFromSun = 10.0f;  

    private float orbitAngle = 0.0f;

    void Update()
    {
        orbitAngle += orbitSpeed * Time.deltaTime;
        orbitAngle %= 360.0f;

        float radians = orbitAngle * Mathf.Deg2Rad;
        Vector3 newPosition = new Vector3(Mathf.Cos(radians) * distanceFromSun, 0, Mathf.Sin(radians) * distanceFromSun);
        transform.position = sun.position + newPosition;
    }
}
