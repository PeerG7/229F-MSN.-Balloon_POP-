using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {
        /*rb.angularVelocity = angularV;*/
        
            rb.angularVelocity = angularV;

            rb.AddTorque(torque);
        
    }
}
