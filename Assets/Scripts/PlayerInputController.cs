using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region TODO
//1.Создать несколько уровней или использовать готовые из прошлого задания. 
//Что нужно сделать
//Настроить контроллер игрока и параметр скорости.

//2. Создать интерактивные объекты.
//Что нужно сделать
//финиш с триггером, при вхождении в который запускается следующий уровень;
//объекты, при столкновении с которыми игрок умирает. Это могут быть шипы, красная плита на полу или спускающаяся сверху
//при приближении игрока, вращающийся молот или другое препятствие. Или зона смерти под уровнем, если с платформ можно упасть. 

//3. Создать зоны с дверями, которые открываются, только если игрок находится рядом (в небольшом триггере) и нажимает клавишу Е. 
//Что нужно сделать
//Подсказку в UI именно при входе в триггер, чтобы игрок понимал, что делать.

//4. Сделать триггеры-кнопки, объекты, при столкновении с которыми игрок включает или выключает другие объекты через SetActive.
//Это могут быть стены, мосты или препятствия, а также целые блоки уровня.

//Советы и рекомендации
//Экспериментируйте! Создайте как можно больше разнообразных препятствий, часть из которых: 
//реагирует на приближение игрока с помощью триггеров;
//статична и может включаться и выключаться с помощью кнопок;
//сделана с помощью анимаций.

//Ресурсы для ознакомления  
//Описание метода Vector3.Lerp()
//Unity Input    
//Unity AddForce

//Что оценивается
//Реализовано задание и использованы знания из предыдущих модулей: 

//методы GetAxis;
//GetKey;
//создание анимаций;
//проверки OnTriggerEnter и OnCollisionEnter;
//переключение сцен.
#endregion

public class PlayerInputController : MonoBehaviour
{    
    PlayerMoveScript playerMove;
    Vector3 vector3;
    bool isJump = false;

    private void Awake()
    {        
        playerMove = GetComponent<PlayerMoveScript>();
        vector3 = Vector3.back;
    }

    private void Update()
    {
        KeyListen();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    
    /// <summary>
    /// Отслеживает нажатия клавиш , управления игроком
    /// </summary>
    void KeyListen()
    {
        var horizontal = Input.GetAxis("Horizontal") * -1;
        var vertical = Input.GetAxis("Vertical") * -1;
        vector3 = new Vector3(horizontal, 0, vertical);
       

        if (transform.position.y <= 0.55)
        {
            isJump = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (isJump == false)
            {
                Debug.Log("Прыжок");
                playerMove.Jump();
                isJump = true;
            }
        }
    }

    /// <summary>
    /// Вызывает метод движения игрока
    /// </summary>
    void MovePlayer()
    {
        playerMove.Move(vector3);
    }

    
}
