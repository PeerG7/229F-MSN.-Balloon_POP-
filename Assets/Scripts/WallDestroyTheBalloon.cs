using UnityEngine;

public class WallDestroyTheBalloon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) // ตรวจสอบว่าชนกับกระสุนหรือไม่
        {
            Destroy(other.gameObject);

        }
    }
}
