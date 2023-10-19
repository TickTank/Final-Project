using System.Collections;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public Rigidbody playerRB;
    private int p_jumpCount = 0;
    public int jumpCount //ENCAPSULATION
    {
        get { return p_jumpCount; }
        set { p_jumpCount = value; }
    }

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
    public virtual void AnimalJump(float height) //ABSTRACTION
    {
        playerRB.AddForce(Vector3.up * height, ForceMode.Impulse);
    }

    public virtual IEnumerator Wait(float wait) //ABSTRACTION
    {
        yield return new WaitForSeconds(wait);
    }
}