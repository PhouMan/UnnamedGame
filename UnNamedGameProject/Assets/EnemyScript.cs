using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{   
    float horizontalSpeed;
    float verticalSpeed;
    Rigidbody2D guybody;
    public float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        guybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = GameObject.Find("SampleGuy").GetComponent<PlayerScript>().playerPosition;
        guybody.position = Vector2.Lerp(guybody.position,playerPosition,Time.deltaTime);


    }
}
