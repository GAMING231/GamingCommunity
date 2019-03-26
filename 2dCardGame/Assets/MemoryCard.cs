﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour {

    public GameObject cardBack; //переменная появиться на панели Inspector

    public SceneController controller;

    private int _id;

    public int id{ get { return _id; } } // добавление функции чтения

    public void SetCard(int id, Sprite image)//метод для передачи указанному объекту новых спрайтов
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)//запускаем код деактивации
        {
            cardBack.SetActive(false); //Делаем объект видимым/невидимым
            controller.CardRevealed(this);// Уведомление контроллера при открытии этой карты.
        }
    }

    public void Unreveal()
    { //позволяет вернуть открытую карты на место
        cardBack.SetActive(true);
    }

}
