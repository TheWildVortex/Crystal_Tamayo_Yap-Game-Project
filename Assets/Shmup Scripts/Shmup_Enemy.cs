using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shmup_Enemy : MonoBehaviour
{

    Rigidbody2D rb;

    public GameObject ebullet, deathexplosion;

    public float xSpeed;
    public float ySpeed;

    public bool canShoot;
    public float fireRate;
    public float deathRate;
    public float health;
    int delay = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Destroy(gameObject,deathRate);
        if (canShoot)
            InvokeRepeating("Shoot", fireRate, fireRate);
    }

    void Update()
    {
        xSpeed = (float)Random.Range(-10, 10);
        rb.velocity = new Vector2(xSpeed, ySpeed * -1);
    }

    void Shoot()
    {
        gameObject.GetComponent<Animator>().Play("MelchiorShoot");
        GameObject Ebull = (GameObject) Instantiate(ebullet, transform.position, Quaternion.identity);
        Ebull.GetComponent<BulletScript>().ChangeDirection();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="PlayerShip")
        {
            col.gameObject.GetComponent<ShipMove>().Damage();
            StartCoroutine(Die());
        }
    }
    IEnumerator Die()
    {
        gameObject.GetComponent<Animator>().Play("MelchiorDeath");
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
        Instantiate(deathexplosion, transform.position, Quaternion.identity);
    }

    public void Damage()
    {
        health--;
        if(health==0)
            StartCoroutine(Die());
    }
}
