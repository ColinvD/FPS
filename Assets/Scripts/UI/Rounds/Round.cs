using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round : MonoBehaviour {

    [SerializeField]
    private Text roundText;
    private int rounds = 1;
    
	// Use this for initialization
	void Start () {
        roundText.text = rounds.ToString();
	}
	
	public void AddRound()
    {
        rounds += 1;
        roundText.text = rounds.ToString();
    }

    public int GetRound()
    {
        return rounds;
    }
}
