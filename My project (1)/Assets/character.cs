using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float movespeed;
      public float jumpheight;
      public KeyCode spacebar;
      public KeyCode L;
public KeyCode R;
public Transform groundcheck;
public float groundcheckradius;
public LayerMask whatisground;
public bool grounded;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(L))
        {
           GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(spacebar) && grounded)
        {
            jump();
        }
    }
void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);
    }

void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }
}
