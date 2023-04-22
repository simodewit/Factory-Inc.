using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 movement;
    public Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;
    private Quaternion look;

    public void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
    }

    public void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;

        if (movement != Vector3.zero)
        {
            look = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, look, rotateSpeed);
        }
    }
}