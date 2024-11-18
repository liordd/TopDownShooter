using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface IEnemies 
{

    float Damage { get; }
    float Speed { get; }
    float Health { get; }
    float MaxHealth { get; }


}


public enum TypeOfEnemies
{

    Skeleton,
    SkeletonWithSword

}

public abstract class Skeletons : MonoBehaviour, IEnemies
{

    public float damage;
    public float speed;
    public float health;
    public float maxHealth;

    public float Damage { get { return damage; } }
    public float Speed  { get { return speed; } }
    public float Health { get { return health; } }
    public float MaxHealth { get { return maxHealth; } }

    public TypeOfEnemies EnemyType { get; }

    public Skeletons(TypeOfEnemies enemyType)
    {
        EnemyType = enemyType;
    }


}




