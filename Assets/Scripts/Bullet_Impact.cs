using UnityEngine;

public class Bullet_Impact : MonoBehaviour
{
    public AudioClip impactSound; // เสียงกระทบ
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // เพิ่ม AudioSource อัตโนมัติ
    }
    void OnCollisionEnter(Collision collision)
    {
        if (impactSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(impactSound); // เล่นเสียงเมื่อกระสุนชน
        }

        Destroy(gameObject, 0.5f); // ทำลายกระสุนหลังจาก 0.5 วินาที
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
