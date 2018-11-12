using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject healthPack;
    [SerializeField]
    private Transform spawnPlace;

    public void SpawnHealthPack()
    {
        Instantiate(healthPack, spawnPlace.position, spawnPlace.rotation);
    }
}
