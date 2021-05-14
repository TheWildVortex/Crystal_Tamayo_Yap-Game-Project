//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class v1Character2DController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    {
        //Grab references from the game objects
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip Player when changing direction
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        //Jump
        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);

        //Set animatior parameters
        anim.SetBool("Run", horizontalInput != 0);
    }
}
