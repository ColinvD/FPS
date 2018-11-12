using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour {
    public Transform target;
    private TimerCountDown timer;

	// Use this for initialization
	void Start () {
        timer = FindObjectOfType<TimerCountDown>();
	}
	
	void OnTriggerEnter (Collider trigger)
    {
        if(trigger.gameObject.tag == "teleport")
        {
            timer.currentTime = 0;
            transform.position = target.position;
        }
    }
}
