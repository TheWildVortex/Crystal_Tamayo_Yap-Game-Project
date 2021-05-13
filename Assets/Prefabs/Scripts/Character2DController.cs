//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    [SerializeField] private float speed;
    //public float MovementSpeed = 1;
    //public float JumpForce = 1;

    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Horizontal Movementv1
        //var movement = GetAxis("Horizontal")
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //Flip Player when changing direction
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        //Jump
        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);

        //Player Jumpv1
        //if (Input.GetButtonDown("Jump") && Mathf.Abs(body.velocity.y) < 0.001f)
        //{
        //    body.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        //}
    }
}
