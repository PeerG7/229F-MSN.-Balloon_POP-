using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bullerPrefab;
    [SerializeField] float force;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Shoot();
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        GameObject bullet = Instantiate(bullerPrefab, this.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddRelativeForce(-Vector3.up * force);


    }
}
