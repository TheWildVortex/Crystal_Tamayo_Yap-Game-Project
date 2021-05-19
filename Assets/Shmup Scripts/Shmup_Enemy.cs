using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shmup_Enemy : MonoBehaviour
{

    Rigidbody2D rb;

    public float xSpeed;
    public float ySpeed;

    public bool canShoot;
    public float fireRate;
    public float health;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(xSpeed,ySpeed*-1);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="PlayerShip")
        {
            col.gameObject.GetComponent<ShipMove>().Damage();
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    public void Damage()
    {
        health--;
        if(health==0)
            Die();
    }
}
