using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float bspeed;
    int direction = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ChangeDirection()
    {
        direction *= -1;
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        rb.velocity = new Vector2(0,bspeed * direction);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bound")
        {
            Destroy(gameObject);
        }

        else if (direction == 1)
        {
            if (col.gameObject.tag == "Enemy")
            {
                col.gameObject.GetComponent<Shmup_Enemy>().Damage();
                Destroy(gameObject);
            }
        }
        else
        {
            if (col.gameObject.tag == "PlayerShip")
            {
                col.gameObject.GetComponent<ShipMove>().Damage();
                Destroy(gameObject);
            }
        }
    }
}
