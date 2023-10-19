using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarAlrededorDelaTierra : MonoBehaviour
{
    public Transform earth; 
    public Transform sun;
    public float orbitSpeed = 20.0f; 
    public float distanceFromEarth = 10.0f;  

    private float orbitAngle = 0.0f;

    void Update()
    {
        orbitAngle += orbitSpeed * Time.deltaTime;
        orbitAngle %= 360.0f;

        float radians = orbitAngle * Mathf.Deg2Rad;
        Vector3 newPosition = new Vector3(Mathf.Cos(radians) * distanceFromEarth, 0, Mathf.Sin(radians) * distanceFromEarth);
        transform.position = earth.position + newPosition;

        Vector3 toSun = sun.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(toSun, earth.up);
        transform.rotation = targetRotation;
    }
}
