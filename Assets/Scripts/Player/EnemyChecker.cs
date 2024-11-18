using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    public Transform playerTransform;
    private Transform currentEnemy;
    public float rotationSpeed = 5f;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            currentEnemy = other.transform;
            Debug.Log("Entered enemy trigger: " + currentEnemy.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (currentEnemy == other.transform)
            {
                Debug.Log("Exited enemy trigger: " + currentEnemy.name);
                currentEnemy = null;
            }
        }
    }

    private void Update()
    {
        if (currentEnemy != null)
        {
            //RotateTowardsEnemy(currentEnemy.position);
        }
    }

    /*private void RotateTowardsEnemy(Vector3 enemyPosition)
    {

        Vector3 targetPosition = new Vector3(enemyPosition.x, playerTransform.position.y, enemyPosition.z);

        playerTransform.LookAt(targetPosition);

    }*/
}
