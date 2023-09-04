using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyScript : MonoBehaviour
{
    public Rigidbody2D guybody;
    public float jumpStrength;
    public float velo_x;
    public float velo_y;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        velo_x = 0;
        velo_y = 0;

        if (Input.GetKey(KeyCode.W) == true)
        {
            velo_y += 1;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            velo_x += 1;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            velo_x -= 1;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            velo_y -= 1;
        }
        guybody.velocity = new Vector2(velo_x,velo_y);
        
    }
}
