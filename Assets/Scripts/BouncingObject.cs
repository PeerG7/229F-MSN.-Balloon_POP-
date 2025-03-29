using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    public float forceStrength = 10f;  
    public float changeDirectionDelay = 2f;  
    private Vector3 currentDirection;
    private ConstantForce constantForce;

    void Start()
    {
        constantForce = GetComponent<ConstantForce>();
        currentDirection = transform.forward; 
        ApplyForce();  
    }

    void ApplyForce()
    {
       
        constantForce.force = currentDirection * forceStrength;
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Invoke("ChangeDirection", changeDirectionDelay);  
    }

    void ChangeDirection()
    {
        currentDirection = -currentDirection;  
        ApplyForce();  
    }
}
