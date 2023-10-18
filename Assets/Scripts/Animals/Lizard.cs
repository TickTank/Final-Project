using System.Collections;
using UnityEngine;

// INHERIT FROM ANIMAL CLASS
public class Lizard : Animal
{
    [SerializeField] bool jumping = false;
    [SerializeField] float wait = 5.0f;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>(); //INHERITED RIGIDBODY FROM ANIMAL CLASS
    }

    void Update()
    {
        if (!jumping) { AnimalJump(jumpForce); }
        
        if (playerRB.velocity.y < 0) {
            playerRB.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime; }
    }

    public override void AnimalJump(float jumpForce) //POLYMORPHED FUNCTION FROM ANIMAL CLASS
    {
        if (!jumping) { playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); jumpNum++; jumping = true; }
    }

    public override IEnumerator Wait(float wait) { //POLYMORPHED FUNCTION FROM ANIMAL CLASS
        yield return new WaitForSeconds(wait);
        jumping = false; }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { StartCoroutine(Wait(wait)); }
    }
}
