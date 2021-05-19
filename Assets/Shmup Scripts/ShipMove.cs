using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    GameObject a, b;
    public GameObject bullet;
    Rigidbody2D rb;
    public float speed;
    public float bulletRate;
    int delay = 0;
    int health = 3;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        a = transform.Find("a").gameObject;
        b = transform.Find("b").gameObject;
    }
    
    void Update()
    {
        //Horizontola movement; from the tutorial
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed,0));

        //Horizontal movement; this is from the platformer
        // var movement = Input.GetAxis("Horizontal");
        // transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        //Vertical movement test; feel free to change this
        rb.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if (Input.GetKey(KeyCode.Space) && delay > bulletRate)
            Shoot();

        delay++;
    }

    public void Damage()
    {
        health--;
        if(health==0)
            Destroy(gameObject);
    }

    void Shoot()
    {
        delay = 0;
        Instantiate(bullet, a.transform.position, Quaternion.identity);
        Instantiate(bullet, b.transform.position, Quaternion.identity);
    }
}
