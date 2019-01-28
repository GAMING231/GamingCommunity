﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

       public enum RotationAxes // Обозначаем структуру данных
       {
           MouseXAndY = 0, //Элементы структуры
           MouseX = 1,
           MouseY = 2
       }

       public RotationAxes axes = RotationAxes.MouseXAndY; // Обозначаем переменную структуры (данная переменная будет отображаться в Inspector)

       public float sensitivityHor = 9.0f; // Переменная скорости по горизонтали
       public float sensitivityVert = 9.0f; // Переменная скорости по вертикали

       public float minimumVert = -45.0f; // Переменная, которая будет ограничивать вертикальный угол нашего героя (угол взгляда вниз)
       public float maximumVert = 45.0f; // Переменная, которая будет ограничивать вертикальный угол нашего героя (угол взгляда вверх)

       public float _rotationX = 0;//Закрытая переменная для сохраннеия угла поворота вертикали.


       void Update () {
           if(axes == RotationAxes.MouseX){ // если мы выберем MouseX в инспекторе

            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0); //Метод GetAxis - выдает нам число (1 или -1 в зависимости от направления движения), класс Input - обрабатывает сигнал с устройства ввода (в данном случае мышь), мы поворачиваемся вокруг оси Y в плоскости X.

           } else if(axes == RotationAxes.MouseY){ // если мы выберем MouseY в инспекторе

               _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert; // обрабатываем сигнал по вертикали и записываем полученное значение в _rotationX
              

           } else { // если мы выберем MouseXAndY в инспекторе
           
        }
    }
}
