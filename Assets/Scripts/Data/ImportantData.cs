using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantData : MonoBehaviour {
    private int score;
    private int kills;
    private int rounds;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

	public int GetScore()
    {
        return score;
    }

    public int GetKills()
    {
        return kills;
    }

    public int GetRounds()
    {
        return rounds;
    }

    public void SetScore(int value)
    {
        score = value;
    }

    public void SetKills(int value)
    {
        kills = value;
    }

    public void SetRounds(int value)
    {
        rounds = value;
    }
}
