using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v2EnemyHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void OnRaycastHit(RaycastWeapon weapon, Vector3 direction)
    {
        currentHealth.TakeDamage(weapon.damage, direction);
    }
   

    public void TakeDamage(float amount, Vector3 direction)
    {
        currentHealth -= amount;
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
