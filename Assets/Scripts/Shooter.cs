using Unity.VisualScripting;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject bullerPrefab;
    [SerializeField] float force;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    
    
    void Shoot()
    {
        GameObject bullet = Instantiate(bullerPrefab, this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
    }

}


