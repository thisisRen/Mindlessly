using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    

    // Update is called once per frame
    void FixedUpdate()
    {

        Movement();
        InteractWithThing();

    }
    
    
    void Movement()
    {
        if (Input.anyKey)
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(h * speed, v * speed);
        }
        else
            rb.velocity = Vector2.zero;
    }

    void InteractWithThing()
    {
        if (Input.GetKey(KeyCode.F))
        {
            // Interact with thing
        }
        
    }
    
    
}
