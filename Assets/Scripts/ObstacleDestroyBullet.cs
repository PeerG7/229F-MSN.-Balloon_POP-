using UnityEngine;

public class ObstacleDestroyBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet")) // ตรวจสอบว่าชนกับกระสุนหรือไม่
        {
            Destroy(other.gameObject);
        }
    }
}
