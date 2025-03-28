using UnityEngine;

public class Momentum : MonoBehaviour
{
    Rigidbody rb;

    void Update()
    {
        rb.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward);
    }
}
