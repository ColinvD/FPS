using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsAmount : MonoBehaviour {
    [SerializeField]
    private Door_Open open;
    [SerializeField]
    private Text killsText;
    [SerializeField]
    private Text coinsText;
    private VariableData data;
    private int kills = 0;
    private int coins = 0;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
        killsText.text = kills.ToString();
        coinsText.text = coins.ToString();
	}
	
	public void AddKills()
    {
        coins++;
        kills++;
        killsText.text = kills.ToString();
        coinsText.text = coins.ToString();
    }

    public void OpenDoor()
    {
        if(coins >= data.GetDeurToll())
        {
            for (int i = 1; i <= data.GetDeurToll(); i++)
            {
                coins--;
            }
            open.OpeningActive();
            coinsText.text = coins.ToString();
        }
    }

    public int GetKills()
    {
        return kills;
    }
}
