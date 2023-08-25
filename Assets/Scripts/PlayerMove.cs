using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10f;
    
    void Start()
    {
        
        verticalInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Move();
    }

    void Move()
    {
        transform.Translate(Time.deltaTime * speed * horizontalInput,0,Time.deltaTime * speed * verticalInput);
    }
}
