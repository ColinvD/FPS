using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {

    [SerializeField]
    private Text timeText;
    private TimerCountDown countdown;
    string extra = "0";
    string text;

    // Use this for initialization
    void Start () {
        countdown = GetComponent<TimerCountDown>();
        timeText.text = "Time: " + countdown.currentTime;
	}
	
	// Update is called once per frame
	void Update () {
        int minutes = countdown.currentTime / 60;
        int seconds = countdown.currentTime % 60;
        if (seconds < 10)
        {
            text = "" + minutes + ":" + extra + seconds;
        }
        else
        {
            text = "" + minutes + ":" + seconds;
        }

        timeText.text = text;
	}
}
