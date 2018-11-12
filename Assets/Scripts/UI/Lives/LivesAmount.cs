using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesAmount : MonoBehaviour {

    [SerializeField]
    private Text livesText;
    private PlayerHealth live;

	// Use this for initialization
	void Start () {
        live = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        livesText.text = live.health.ToString();
	}
}
