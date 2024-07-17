using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public Rigidbody rb;
    public float forwardForce;
    public float sideForce;
    public float jumpForce;
    public bool isOnGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //Move right
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            //move left
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        //player jump method
        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        if(rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
