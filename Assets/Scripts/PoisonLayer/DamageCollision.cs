using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour {

    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().LoseLife(20, "Poison");
        }
        if (other.GetComponent<PlayerHealth>())
        {
            other.GetComponent<PlayerHealth>().DestroyHealth();
        }
    }
}
