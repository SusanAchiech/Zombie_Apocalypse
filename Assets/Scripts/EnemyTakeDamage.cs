using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    
    public int maxHealth = 10;
    private int currentHealth;
    public bool enemyDead = false;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void TargetDestroy()
    {

        if (!enemyDead)
        {
            enemyDead = true;
            Debug.Log("Enemy destroyed");
            gameObject.SetActive(false);
        }
    }

    void Die()
    {
        // Implement death behavior (e.g., play death animation, deactivate GameObject, etc.).
        // You can also handle scoring or other game logic here.
        gameObject.SetActive(false);
    }
}

