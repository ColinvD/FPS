using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private KillsAmount currentKills;
    [SerializeField]
    private ScoreText scoreText;
    private VariableData data;
    private int score = 10;
    private int lives;

	// Use this for initialization
	void Start () {
        currentKills = GameObject.FindGameObjectWithTag("GameManager").GetComponent<KillsAmount>();
        scoreText = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreText>();
        data = FindObjectOfType<VariableData>();
        lives = data.GetEnemyHealth();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
	}

    public void LoseLife(int amount, string byWhat)
    {
        lives -= amount;
        if (lives <= 0 && byWhat == "Poison")
        {
            Destroy(gameObject);
        } else if(lives <= 0 && byWhat == "Player")
        {
            currentKills.AddKills();
            scoreText.AddScore(score);
            Destroy(gameObject);
        }
    }
}
