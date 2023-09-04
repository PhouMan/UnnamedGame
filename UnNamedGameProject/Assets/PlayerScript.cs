using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float horizontalSpeed;
    float verticalSpeed;
    Rigidbody2D guybody;
    public Vector2 playerPosition;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        guybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = guybody.position;
        horizontalSpeed = Input.GetAxisRaw("Horizontal");
        verticalSpeed = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (horizontalSpeed != 0 && verticalSpeed != 0)
        {
            horizontalSpeed *= 0.7f;
            verticalSpeed *= 0.7f;
        }
        guybody.velocity = new Vector2(horizontalSpeed * moveSpeed, verticalSpeed * moveSpeed);
    }
}
