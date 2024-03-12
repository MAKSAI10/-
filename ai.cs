using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
     public Transform player; // Цель, за которой будет следовать противник
    public float speed; // Скорость передвижения противника
    [Space (30)]    

    
    [Header ("дистанция видимости персонажа")] 
    public float followDistance; // Дистанция, на которой противник перестанет следовать

    void Update()
    {
        // Получаем направление к игроку
        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        // Проверяем дистанцию до игрока
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= followDistance)
        {
            // Перемещаем противника в направлении к игроку
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}