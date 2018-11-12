using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableData : MonoBehaviour {

    private int enemyLimit = 15;
    private float enemySpeed = 3;
    private int enemyHealth = 3;
    private int enemyDamage = 5;
    private int maxTimeDuration = 120;
    private int healthContainer = 100;
    private int ammoContainer = 10;
    private int deurToll = 10;
    private int playerID;
    private int score;
    private int rounds;
    private int kills;
    private int shotted;
    private int damaged;
    private int hpPacks_picked;

    public int GetEnemyLimit()
    {
        return enemyLimit;
    }
    public float GetEnemySpeed()
    {
        return enemySpeed;
    }
    public int GetEnemyHealth()
    {
        return enemyHealth;
    }
    public int GetEnemyDamage()
    {
        return enemyDamage;
    }
    public int GetMaxTimeDuration()
    {
        return maxTimeDuration;
    }
    public int GetHealthContainer()
    {
        return healthContainer;
    }
    public int GetAmmoContainer()
    {
        return ammoContainer;
    }
    public int GetDeurToll()
    {
        return deurToll;
    }

    public void ChangeEnemyLimit()
    {
        enemyLimit += 2;
        if (enemyLimit > 100)
        {
            enemyLimit = 100;
        }
    }
    public void ChangeEnemySpeed()
    {
        enemySpeed += 0.5f;
        if (enemySpeed > 8)
        {
            enemySpeed = 8;
        }
    }
    public void ChangeEnemyHealth()
    {
        enemyHealth += 1;
        if (enemyHealth > 20)
        {
            enemyHealth = 20;
        }
    }
    public void ChangeEnemyDamage()
    {
        enemyDamage += 3;
        if (enemyDamage > 100)
        {
            enemyDamage = 100;
        }
    }
    public void ChangeMaxTimeDuration()
    {
        maxTimeDuration -= 2;
        if (maxTimeDuration < 60)
        {
            maxTimeDuration = 60;
        }
    }
    public void ChangeHealthContainer()
    {
        healthContainer -= 2;
        if (healthContainer < 20)
        {
            healthContainer = 20;
        }
    }
    public void ChangeAmmoContainer()
    {
        ammoContainer += 5;
        if (ammoContainer > 300)
        {
            ammoContainer = 300;
        }
    }
    public void ChangeDeurToll()
    {
        deurToll += 10;
        if (deurToll > 500)
        {
            deurToll = 500;
        }
    }
}
