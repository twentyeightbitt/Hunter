using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    /*public int coins = 0;
    public TextMeshProUGUI coinsText;*/
    [SerializeField] GameObject _startMenu;
 

    public void Play()
    {
        _startMenu.SetActive(false);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            coins++; //++ - операция инкремента, которая увеличивает значение числовой переменной на 1. -- - это декремент, она обратная.
            Destroy(collision.gameObject);
            coinsText.text = "Coins: " + coins;
        }
        if (collision.gameObject.CompareTag("Grow"))
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(collision.gameObject);
        }
    }*/






}

