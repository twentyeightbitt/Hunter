using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    public static GameManager Manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Manager.addPoints();
        }
    }

    private void Start()
    {
        Manager = GameManager.Instance;
    }
}
