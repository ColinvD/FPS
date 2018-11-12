using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountDown : MonoBehaviour {

    private VariableData data;
    public int currentTime;
    private int maxTime;
    private int minute = 60;
    private float second;
    private int secondsPast = 0;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
        maxTime = data.GetMaxTimeDuration();
        currentTime = maxTime;
        StartCoroutine("Count");
	}

    public IEnumerator Count()
    {
        while (currentTime > 0)
        {
            currentTime -= 1;
            secondsPast++;
            yield return new WaitForSeconds(1f);
        }
    }

    public int GetSecondsPast()
    {
        return secondsPast;
    }
}
