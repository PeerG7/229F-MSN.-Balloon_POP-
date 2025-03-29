using UnityEngine;
using UnityEngine.Audio;

public class Sound_when_shot : MonoBehaviour
{
    public AudioSource Source;  // ตัวเล่นเสียง
    public AudioClip Sound;  // ไฟล์เสียงปุ่ม

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Source == null)
            Source = GetComponent<AudioSource>(); // ค้นหา AudioSource ใน GameObject นี้

        if (Sound != null)
            Source.clip = Sound; // ตั้งค่าเสียง
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ตรวจจับการกดปุ่ม W
        {
            if (Source != null && Sound != null)
            {
                Source.PlayOneShot(Sound); // เล่นเสียงเมื่อกด W
            }
        }
    }
}
