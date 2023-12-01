using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHorizontalPlatform : MonoBehaviour
{
    public float speed = 3f; // Скорость движения платформы
    public float leftBound = -3f; // Левая граница
    public float rightBound = 3f; // Правая граница

    bool movingRight = true; // Флаг для определения направления движения

    void Update()
    {
        // Проверяем направление движения и перемещаем платформу
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime); // Движение вправо
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime); // Движение влево
        }

        // Проверяем, достигла ли платформа границы и меняем направление движения
        if (transform.position.x >= rightBound)
        {
            movingRight = false;
        }
        else if (transform.position.x <= leftBound)
        {
            movingRight = true;
        }
    }
}
