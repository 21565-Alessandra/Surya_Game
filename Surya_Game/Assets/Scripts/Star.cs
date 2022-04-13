using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public float speed = 120f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); //store x axis movement as float

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        
    }
}
