using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    float speed = 7f;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Move();
    }

    void Move()
    {
        transform.Translate(Time.deltaTime * speed * horizontalInput,0,Time.deltaTime * speed * verticalInput,Space.World);
    }
}
