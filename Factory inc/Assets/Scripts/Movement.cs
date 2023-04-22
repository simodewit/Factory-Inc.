using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Movement : NetworkBehaviour
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
        if (isOwned)
        {
            rb.velocity = movement * moveSpeed;

            if (movement != Vector3.zero)
            {
                look = Quaternion.LookRotation(movement, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, look, rotateSpeed);
            }
        }      
    }
}
