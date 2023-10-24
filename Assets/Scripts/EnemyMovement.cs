using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform follow;

    private UnityEngine.AI.NavMeshAgent agent;

    //float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
            agent.SetDestination(follow.position);
       /* if (timer <= 0)
        {
            timer = 1;
        }*/

        /*timer -= Time.deltaTime;*/

        //timer -= Time.DeltaTime is similar to writing timer = timer - Time.deltaTime
    }

}

