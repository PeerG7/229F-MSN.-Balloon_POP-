using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{

    public int scoreValue = 10; // คะแนนที่เพิ่มเมื่อ Enemy ถูกทำลาย

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet")) // ตรวจสอบว่าชนกับกระสุนหรือไม่
        {
            EndScenes.Instance.AddScore(scoreValue);
            Destroy(gameObject); // ทำลาย Enemy
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.CompareTag("Nugget")) // ตรวจสอบว่าชนกับกระสุนหรือไม่
        {
            EndScenes.Instance.AddScore(scoreValue);
            Destroy(gameObject); // ทำลาย Enemy
        }
    }
}