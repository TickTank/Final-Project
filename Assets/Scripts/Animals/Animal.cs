using System.Collections;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public Rigidbody playerRB; //{ get; private set; }
    public int jumpCount = 0;
    public int jumpNum = 0;

    public float jumpForce;
    public float gravityModifier = 1.5f;
    public float fallMultiplier = 2.5f;

    private void Start()
    {
        Physics.gravity *= gravityModifier;
    }
    public virtual void findPos(Vector3 target)
    {
        transform.LookAt(target);
    }

    public virtual void AnimalJump(float height)
    {
        playerRB.AddForce(Vector3.up * height, ForceMode.Impulse);
    }

    public virtual IEnumerator Wait(float wait)
    {
        yield return new WaitForSeconds(wait);
    }
}