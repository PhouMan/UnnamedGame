using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyScript : MonoBehaviour
{
    public Rigidbody2D guybody;
    public float jumpStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            guybody.velocity = Vector2.up*jumpStrength;
        }

        else if (Input.GetKey(KeyCode.D) == true)
        {
            guybody.velocity = Vector2.right * jumpStrength;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            guybody.velocity = Vector2.left * jumpStrength;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            guybody.velocity = Vector2.down * jumpStrength;
        }
        else
        {
            guybody.velocity = Vector2.zero;
        }
    }
}
