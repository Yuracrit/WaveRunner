using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMovementPlatform : MonoBehaviour
{
    public float rotationSpeed = 50f; // Скорость вращения платформы

    void Update()
    {
        
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}