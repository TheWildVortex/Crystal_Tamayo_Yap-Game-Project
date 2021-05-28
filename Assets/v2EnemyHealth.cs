using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v2EnemyHealth : MonoBehaviour
{
    public float maxHealth = 3.0f;
    public float currentHealth;
    public GameObject deathexplosion;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void OnRaycastHit(RaycastWeapon weapon)
    {
        currentHealth -= weapon.damage;
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Instantiate(deathexplosion, transform.position, Quaternion.identity);
    }
}
