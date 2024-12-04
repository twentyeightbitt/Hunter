using UnityEngine;

public class MoveBullet1 : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;
    public Transform barrel;
    public Transform enemyPos;
    private Quaternion _bulletRotation;
    
    void Update()
    {
        _bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -90);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, barrel.position, _bulletRotation);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Instantiate(enemy, enemyPos.position, enemy.transform.rotation);
        }
    }
}
