using System.Collections;
using UnityEngine;

// INHERIT FROM ANIMAL CLASS
public class Snake : Animal
{
    Vector3 targetPos;
    GameObject player;
    [SerializeField]
    float speed = 45.5f, wait = 0.0f;
    [SerializeField] bool jumping = false; 

    void Start()
    {
        player = GameObject.Find("Player");
        playerRB = GetComponent<Rigidbody>(); //INHERITED RIGIDBODY FROM ANIMAL CLASS
    }
    
    void Update()
    {
        Move(); 

        if (!jumping) { AnimalJump(jumpForce); }

        if (playerRB.velocity.y < 0) { 
            playerRB.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime; }
    }

    public override void AnimalJump(float jumpForce) //POLYMORPHED FUNCTION FROM ANIMAL CLASS 
    {
        if (!jumping) { playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); jumpNum++; jumping = true; }
    }
    public override IEnumerator Wait(float wait) //POLYMORPHED FUNCTION FROM ANIMAL CLASS 
    {
        yield return new WaitForSeconds(wait);
        jumping = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { StartCoroutine(Wait(wait)); }
    }

    void Move()
    {
        findPos();
        playerRB.AddForce((player.transform.position - transform.position).normalized * speed);
    }

    void findPos()
    {
        targetPos = player.transform.position;
        transform.LookAt(targetPos);
    }
}