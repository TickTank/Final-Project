using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    float speed = 7f;

    Camera playercam;

    private void Start()
    {
        playercam = GameObject.Find("playerCamera").GetComponent<Camera>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Move();
    }

    void Move()
    {
        transform.Translate(Time.deltaTime * speed * horizontalInput,0,Time.deltaTime * speed * verticalInput,Space.World);

        //transform.position = new Vector3(Time.deltaTime * speed * horizontalInput,0,Time.deltaTime * speed * verticalInput) + playercam.transform.forward * speed * Time.deltaTime;
    }
}
