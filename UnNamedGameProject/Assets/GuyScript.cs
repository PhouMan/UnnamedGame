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
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            guybody.velocity = Vector2.up*jumpStrength;
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            guybody.velocity = Vector2.right * jumpStrength;
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            guybody.velocity = Vector2.left * jumpStrength;
        }
    }
}
