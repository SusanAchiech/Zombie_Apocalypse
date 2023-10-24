using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public Transform player;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Animator zombieAnimator;

    public float walkDistance = 10.0f; // Distance at which the zombie starts walking.
    public float runDistance = 5.0f;   // Distance at which the zombie starts running.

    


    private void Start()
    {
        navMeshAgent = GetComponent < UnityEngine.AI.NavMeshAgent>();

        if (player != null)
        {
            // Set the player's position as the target destination for the zombie.
            zombieAnimator.SetFloat("Speed", 0.5f);
            navMeshAgent.SetDestination(player.position);
        }
    }

   /*private void OnAnimationZ_Attack()
    {
        if (zombieAnimator != null)
        {
            zombieAnimator.AnimationZ_Attack();
        }
    }*/
    private void Update()
    {
        // Calculate the distance between the zombie and the player.
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Determine the animation speed based on the distance.
        if (distanceToPlayer > walkDistance)
        {
            // Far from the player, so make the zombie walk.
            zombieAnimator.SetFloat("Speed", 0.5f); // Adjust the speed as needed.
        }
        else if (distanceToPlayer > runDistance)
        {
            // Close to the player but not too close, so make the zombie walk faster.
            zombieAnimator.SetFloat("Speed", 1.0f); // Adjust the speed as needed.
        }
        else
        {
            // Very close to the player, so make the zombie run.
            zombieAnimator.SetFloat("Speed", 2.0f); // Adjust the speed as needed.
        }
    }
}

