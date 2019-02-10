using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//подключение бибилиотеки для UI-системы 

public class Shoot : MonoBehaviour {

    private Camera _camera; //Перменная тип Camera

    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();//Доступ к компонентам
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //реакция на нажатие кнопки мыши
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0); //середина экрана, половина ширины и высоты

        }
    }
}
