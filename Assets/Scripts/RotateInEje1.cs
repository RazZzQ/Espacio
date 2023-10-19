using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateInEje1 : MonoBehaviour
{
    public float rotationSpeed = 20.0f; 

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
