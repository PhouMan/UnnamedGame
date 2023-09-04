using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{   
    float horizontalSpeed;
    float verticalSpeed;
    Rigidbody2D guybody;
    Vector2 playerPosition;
    public float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        guybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = GameObject.Find("PlayerBody").GetComponent<PlayerScript>().playerPosition;
        guybody.position = Vector2.Lerp(guybody.position,playerPosition,Time.deltaTime);


    }
}
