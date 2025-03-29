using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    public int scoreValue = 10; // คะแนนที่เพิ่มเมื่อ Enemy ถูกทำลาย

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet")) // ตรวจสอบว่าชนกับกระสุนหรือไม่
        {
            Destroy(gameObject); // ทำลาย Enemy
            Destroy(other.gameObject);
            EndScenes.Instance.AddScore(scoreValue);  // เพิ่มคะแนน
        }
    }
}