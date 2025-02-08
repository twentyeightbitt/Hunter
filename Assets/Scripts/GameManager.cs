using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int coins = 0;
    public TextMeshProUGUI coinsText;
    [SerializeField] GameObject _startMenu;
    public static GameManager Instance;
 

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


    public void addPoints()
    {
        coins++;
        coinsText.text = "POINTS: " + coins;
    }


    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;  
                
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }






}

