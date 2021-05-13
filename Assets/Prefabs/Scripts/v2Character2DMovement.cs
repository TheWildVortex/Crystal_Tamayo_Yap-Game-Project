using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v2Character2DMovement : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        //Horizontal Movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //Player Jump
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
