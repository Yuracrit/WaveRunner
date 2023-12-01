using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float minHeight = 1.0f; // Минимальная высота
    public float maxHeight = 5.0f; // Максимальная высота
    public float fallSpeed = 4.0f; // Скорость падения
    public float riseSpeed = 1.0f; // Скорость подъема
    public float fallDuration = 1.0f; // Длительность падения

    private float currentHeight;
    private bool isFalling = true;
    private float fallTimer = 0.0f;

    void Update()
    {
        if (isFalling)
        {
            // Падение объекта вниз
            fallTimer += Time.deltaTime;
            float fallStep = fallSpeed * Time.deltaTime;

            if (fallTimer < fallDuration)
            {
                transform.Translate(Vector3.down * fallStep);
            }
            else
            {
                isFalling = false;
                fallTimer = 0.0f;
            }
        }
        else
        {
            // Подъем объекта вверх
            float riseStep = riseSpeed * Time.deltaTime;

            if (transform.position.y < maxHeight)
            {
                transform.Translate(Vector3.up * riseStep);
            }
            else
            {
                isFalling = true;
            }
        }
    }
}


