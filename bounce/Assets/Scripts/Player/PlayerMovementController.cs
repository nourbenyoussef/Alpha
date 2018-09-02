using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour {
    public float Speed;
    public float JumpForce;
    public int MaxJumps;
    public LayerMask GroundLayer;
   
    public bool RotateOnMove;
    public bool CanGoLeft;


    Rigidbody2D rb;
    SpriteRenderer sr;
    
    int jumps = 0;
     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }
   
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (!CanGoLeft)
            moveHorizontal = Mathf.Clamp(moveHorizontal, 0, 1);
        // look
        if (moveHorizontal > 0 && transform.rotation.y != 0)
            transform.rotation = Quaternion.identity;
        else if (moveHorizontal < 0 && transform.rotation.y != 180)
            transform.rotation = new Quaternion(0, 180, 0, 0);

        // ground test
        var grounded = Physics2D.Raycast(transform.position, -Vector2.up, sr.bounds.size.y, GroundLayer);

        // jump
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // check if the player is grounded
            if (grounded || jumps < MaxJumps)
            {
                rb.AddForce(Vector2.up * JumpForce);
                jumps++;
                

            }


        }
        else if (grounded && jumps > 0 && rb.velocity.y <= 0)
            jumps = 0;
        

  
        // run
        rb.velocity = new Vector2(moveHorizontal * Speed, rb.velocity.y);
        
    }

}

