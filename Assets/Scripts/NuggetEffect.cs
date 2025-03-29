using Unity.VisualScripting;
using UnityEngine;

public class NuggetEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    public float destroyTime = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sikekick yike
            kick();
        }
        //apply magnut effect
        magnuteffect();

    }
    void kick()
    {
        
        rb.linearVelocity = velocity;
        
        rb.angularVelocity = spin;

    }
    void magnuteffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);

        rb.AddForce(magnusForce);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject, destroyTime);
        }
    }
}
