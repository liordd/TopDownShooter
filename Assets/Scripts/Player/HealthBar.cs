using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float MaxHealth = 100;
    public float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //HealObjectTaken();
    }

    public void DamageTaken()
    {



    }


    /*private void OnCollisionEnter(Collision collision)
    {
        if (other.CompareTag("Enemy"))
        {
            currentEnemy = other.transform;
            Debug.Log("Entered enemy trigger: " + currentEnemy.name);
        }
    }*/



}
