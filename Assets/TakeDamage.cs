/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int maxHealth;
    public int EnemyHealth;

    bool enemyDead;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth = maxHealth;
    }

    private void EnemyKilled()
    {
        if (!enemyDead)
        {
            enemyDead = true;
            Debug.Log("Zombie dead");
            gameObject.SetActive(false);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Check if the collision object has a "Projectile" component.
            Projectile projectile = collision.gameObject.GetComponent<Projectile>();
            if (projectile != null)
            {
                EnemyHealth -= projectile.damage;

                if (EnemyHealth <= 0)
                {
                    EnemyKilled();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}*/
