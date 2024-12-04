using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    public float sensitivity = 2.0f;

    
    
    void Update()
    {
        
        _horizontal = Input.GetAxis("Mouse X") * sensitivity;
        _vertical = Input.GetAxis("Mouse Y");

        transform.Rotate(0, _horizontal, 0);
        transform.Rotate(0, 0, _vertical);
    }
}
