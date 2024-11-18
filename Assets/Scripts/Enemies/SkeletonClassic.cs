using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonClassic : Skeletons, IEnemies
{

    public Transform playerTransform;
    public Transform Enemy;
    private UnityEngine.AI.NavMeshAgent EnemyAgent;




    public SkeletonClassic() : base(TypeOfEnemies.Skeleton)
    {
        damage = 10f;
        health = 20f;
        maxHealth = 20f;
    }

    void Start()
    {
        EnemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
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
