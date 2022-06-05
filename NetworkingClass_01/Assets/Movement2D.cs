using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Movement2D : NetworkBehaviour
{
    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Transform playerTransform;

    [SerializeField]
    Rigidbody2D rb;

    float verticalInput, horizontalInput;

    
    void Update()
    {
        if (!isLocalPlayer) return;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(
            horizontalInput * movementSpeed,
            verticalInput * movementSpeed
        );
    }
}
