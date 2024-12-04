using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public int spawnCount = 1;
    public GameObject[] enemies;

    private Vector3 _position;
    private int _index;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }

    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            _position = new Vector3(Random.Range(-90, -70), 11, Random.Range(120, 190));
            _index = Random.Range(0, enemies.Length);
            Instantiate(enemies[_index], _position, enemies[_index].transform.rotation);
        }
        if (spawnCount < 3) 
            spawnCount++;
    }
}
