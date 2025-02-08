using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    [Range(1, 50)] public int speed = 30;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Enemy"))
    //    {
    //        Destroy(other.gameObject);
    //        Destroy(gameObject);
    //    }


    //}

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
