using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackPickup : MonoBehaviour {

    private PlayerHealth lives;
    private VariableData data;

	// Use this for initialization
	void Start () {
        lives = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        data = FindObjectOfType<VariableData>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "HealthPack")
        {
            lives.GainHealth(data.GetHealthContainer());
            Destroy(other.gameObject);
        }
    }
}
