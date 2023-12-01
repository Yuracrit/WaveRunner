using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    public float minScale = 0.5f; // Минимальный размер
    public float maxScale = 2.0f; // Максимальный размер
    public float scaleSpeed = 1.0f; // Скорость изменения размера

    private bool increasing = true; // Флаг для отслеживания увеличения/уменьшения

    void Update()
    {
        // Изменяем масштаб платформы
        float scaleFactor = scaleSpeed * Time.deltaTime;

        if (increasing)
        {
            transform.localScale += new Vector3(scaleFactor, scaleFactor, 0f);

            if (transform.localScale.x >= maxScale)
            {
                increasing = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(scaleFactor, scaleFactor, 0f);

            if (transform.localScale.x <= minScale)
            {
                increasing = true;
            }
        }
    }
}
