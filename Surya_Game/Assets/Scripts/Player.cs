using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 30f;
    Transform check;
    public Transform firstCheck;

    private void Start()
    {
        check = firstCheck;
    }
    private void OnTriggerEnter2D(Collider2D co)
    {
        if(co.name == "checkpoint")
        {
            check = co.transform;
        }
    }
    private void OnCollisionEnter2D(Collision2D co)
    {
        if(co.collider.name == "meteor")
        {
            //reset gravity, rotation, velocity, position to last check
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().gravityScale = Mathf.Abs(GetComponent<Rigidbody2D>().gravityScale);
            transform.position = check.position;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        //animation
        GetComponent<Animator>().SetInteger("DirX",(int)h);

        
    }

    private void Update()
    {
        //gravity flip
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded())
        {
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            transform.Rotate(0, 180, 180); //turn character
        }
    }

    public bool isGrounded()
    {
        //get boundary of collider
        Bounds bounds = GetComponent<Collider2D>().bounds;
        //calculate casting range
        float range = bounds.extents.y * 1.2f;
        //get vector position below collider using range and transform.up 
        //so it will behave with gravity
        Vector2 v = bounds.center - transform.up * range;

        //draw linecast
        RaycastHit2D hit = Physics2D.Linecast(v, bounds.center);

        //did the line hit another collider, and not ourself?
        return (hit.collider.gameObject != gameObject);

    }
}
