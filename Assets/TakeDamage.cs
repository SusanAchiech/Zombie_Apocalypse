/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TakeDamage : MonoBehaviour
 {
              public int maxHealth;
               public int EnemyHealth;

               bool enemyDead;
       bool routineStarted = false;

       public bool isHit = false;

       [Header("Audio")]

       public AudioClip downSound;

       [Header("Animations")]
       public AnimationClip ZombieFallingBackwards;


       public AudioSource audioSource;
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
                       if (isHit == true)
                       {
                           if (routineStarted == false)
                           {
                               //Animate the target "down"
                               gameObject.GetComponent<Animation>().clip = ZombieFallingBackwards;
                               gameObject.GetComponent<Animation>().Play();

                               //Set the downSound as current sound, and play it
                               audioSource.GetComponent<AudioSource>().clip = downSound;
                               audioSource.Play();

                               //Start the timer

                               routineStarted = true;
                           }
                       }
                        }

               // Update is called once per frame
               void Update()
                       {

                       }


public int maxHealth = 100;
    private int currentHealth;

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

    void Die()
    {
        // Implement death behavior (e.g., play death animation, deactivate GameObject, etc.).
        // You can also handle scoring or other game logic here.
        gameObject.SetActive(false);
    }
}*/

