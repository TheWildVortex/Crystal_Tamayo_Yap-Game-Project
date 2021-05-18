using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //Horizontola movement; from the tutorial
        //rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed,0));

        //Horizontal movement; this is from the platformer
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        //Vertical movement test; feel free to change this
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));
    }
}
