using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");     
        Vector3 move = new Vector3(moveX, 0, 0);     
        controller.Move(move * speed * Time.deltaTime);
    }
}