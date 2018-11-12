using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    private VariableData data;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        if(Physics.Raycast(ray, out hit, 1f))
        {
            if(hit.collider.gameObject.tag == "Player")
            {
                hit.collider.GetComponent<PlayerHealth>().LoseHealth(data.GetEnemyDamage());
            }
        }
	}
}
