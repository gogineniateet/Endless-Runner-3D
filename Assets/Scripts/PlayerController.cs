using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerJumpForce;
    public float PlayerSpeed;
    bool isGrounded = true;
    Rigidbody rb;
    int score;
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(PlayerSpeed, rb.velocity.y, rb.velocity.z);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * playerJumpForce);
            isGrounded = false;
        }
        score = (int)transform.position.x;
        Debug.Log("Score :" + score);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ObstacleController>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}
