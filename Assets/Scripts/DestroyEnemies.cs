using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using System.Diagnostics;
using System;

public class DestroyEnemies : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinsText;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            coins++; //++ - операция инкремента, которая увеличивает значение числовой переменной на 1. -- - это декремент, она обратная.
            Destroy(collision.gameObject);
            coinsText.text = "POINTS: " + coins;
        }
        Console.WriteLine("fdsfasd");
    }
}
