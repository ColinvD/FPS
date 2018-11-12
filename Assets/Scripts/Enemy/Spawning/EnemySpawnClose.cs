using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnClose : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;
    private float spawnTime = 0.5f;
    private float nextEnemy;
    private Transform playerPosition;
    private GameObject[] enemySpawn;
    [SerializeField]
    private List<Transform> closest;
    private VariableData data;
    private ChangeValues active;
    public List<Transform> enemySpawnTransform;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemySpawn = GameObject.FindGameObjectsWithTag("SpawnPoints");
        active = FindObjectOfType<ChangeValues>();
        for(int i = 0; i < enemySpawn.Length; i++)
        {
            enemySpawnTransform.Add(enemySpawn[i].GetComponent<Transform>());
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextEnemy && GameObject.FindGameObjectsWithTag("Enemy").Length < data.GetEnemyLimit() && active.SpawnOrNot())
        {
            closest = GetClosestSpawnpointsToPlayer();
            nextEnemy = Time.time + spawnTime;
            int randomValue = Random.Range(0, 3);
            Debug.Log(randomValue);
            Instantiate(enemy, closest[randomValue].position, closest[randomValue].rotation);
        }
    }
    /*
    Transform GetClosestSpawnpointToPlayer()
    {
        Transform closestPoint = null;
        float smallestDistance = float.MaxValue;

        for (int i = 0; i < enemySpawnTransform.Count; i++)
        {
            if(Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position) < smallestDistance)
            {
                closestPoint = enemySpawnTransform[i];
                smallestDistance = Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position);
            }
        }
        return closestPoint;
    }*/

    List<Transform> GetClosestSpawnpointsToPlayer()
    {
        List<Transform> closestPoints = new List<Transform>();
        closestPoints.Add(enemySpawnTransform[0].transform);
        for (int i = 1; i < enemySpawnTransform.Count; i++)
        {
            if (Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position) >= Vector3.Distance(closestPoints[0].position, playerPosition.position))
            {
                closestPoints.Add(enemySpawnTransform[i].transform);
            }
            else
            {
                for (int j = 0; j < closestPoints.Count; j++)
                {
                    if (Vector3.Distance(enemySpawnTransform[i].position, playerPosition.position) <= Vector3.Distance(closestPoints[j].position, playerPosition.position))
                    {
                        closestPoints.Insert(j, enemySpawnTransform[i].transform);
                        break;
                    }
                }
            }
        }
        return closestPoints;
    }
}