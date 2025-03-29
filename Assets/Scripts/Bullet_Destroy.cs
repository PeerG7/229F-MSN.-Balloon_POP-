using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 1f; 

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) 
        {
            Destroy(other.gameObject); 
            Destroy(gameObject); 
        }
    }
}
