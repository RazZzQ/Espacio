using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSol : MonoBehaviour
{
    public float rotationSpeed = 10.0f; // Velocidad de rotaci�n del Sol en grados por segundo.

    void Update()
    {
        // Rotar el Sol sobre su propio eje en funci�n de la velocidad definida.
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
