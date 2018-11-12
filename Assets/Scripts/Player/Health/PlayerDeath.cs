using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    [SerializeField]
    private PlayerHealth health;
    [SerializeField]
    private ChangeScene sceneChanger;
    [SerializeField]
    private ImportantData data;
    [SerializeField]
    private KillsAmount killsAmount;
    [SerializeField]
    private Round round;
    [SerializeField]
    private ScoreText score;

    // Use this for initialization
    void Start () {
        health = FindObjectOfType<PlayerHealth>();
        if (!(FindObjectOfType<ChangeScene>()))
        {
            sceneChanger = gameObject.AddComponent<ChangeScene>();
        }
        //sceneChanger = FindObjectOfType<ChangeScene>();
	}
	
	// Update is called once per frame
	void Update () {
		if(health.health <= 0)
        {
            data.SetKills(killsAmount.GetKills());
            data.SetRounds(round.GetRound());
            data.SetScore(score.GetScore());
            sceneChanger.ChangingScenes(2);
        }
	}
}
