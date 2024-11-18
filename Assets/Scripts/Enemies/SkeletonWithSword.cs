using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonWithSword : Skeletons, IEnemies
{

    public Transform playerTransform;
    public Transform Enemy;
    private UnityEngine.AI.NavMeshAgent EnemyAgent;

    public SkeletonWithSword() : base(TypeOfEnemies.Skeleton)
    {
        damage = 30f;
        health = 25f;
        maxHealth = 25f;
    }


    void Start()
    {
        EnemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        Chasing();
    }



    public void Chasing()
    {
        WalkTowardsPlayer();


    }

    public void WalkTowardsPlayer()
    {
        EnemyAgent.SetDestination(playerTransform.position);

        Vector3 targetPosition = new Vector3(playerTransform.position.x, Enemy.position.y, playerTransform.position.z);

        Enemy.LookAt(targetPosition);
    }
}
