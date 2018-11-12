using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeValues : MonoBehaviour {

    private RaiseLair poison;
    private TimerCountDown timer;
    private Round round;
    private VariableData data;
    private HealthPackSpawn healthpack;
    private FallFloor floorFall;
    private Fall[] doorsFall;
    private MouseSettings mouseSettings;
    private Door_Open doorOpen;
    private int randomNumber;
    private bool oneTimeOnly = true;
    [SerializeField]
    private Text[] doorTexts;

    [SerializeField]
    private Text popupText;
    [SerializeField]
    private GameObject popupScreen;

    // Use this for initialization
    void Start () {
        poison = FindObjectOfType<RaiseLair>();
        timer = FindObjectOfType<TimerCountDown>();
        round = FindObjectOfType<Round>();
        data = FindObjectOfType<VariableData>();
        healthpack = FindObjectOfType<HealthPackSpawn>();
        floorFall = FindObjectOfType<FallFloor>();
        doorsFall = FindObjectsOfType<Fall>();
        mouseSettings = FindObjectOfType<MouseSettings>();
        doorOpen = FindObjectOfType<Door_Open>();
        for (int i = 0; i < doorTexts.Length; i++)
        {
            doorTexts[i].text = "You need: " + data.GetDeurToll() + " coins to open the door";
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (timer.currentTime <= 0 && oneTimeOnly)
        {
            poison.StartCoroutine("Raise");
            timer.currentTime = 0;
            healthpack.SpawnHealthPack();
            oneTimeOnly = !oneTimeOnly;
        }
        if(timer.currentTime < 0)
        {
            timer.currentTime = 0;
        }
        if(poison.AreYouDone())
        {
            mouseSettings.CursorVisable();
            randomNumber = Random.Range(0, 8);
            poison.Reset();
            Time.timeScale = 0;
            popupScreen.SetActive(true);
            switch (randomNumber)
            {
                case 0: data.ChangeEnemyLimit();
                    popupText.text = "You're on to the next round and there can be more enemies on the map";
                    break;
                case 1: data.ChangeEnemySpeed();
                    popupText.text = "You're on to the next round and the enemies are faster";
                    break;
                case 2: data.ChangeEnemyHealth();
                    popupText.text = "You're on to the next round and the enemies have more health";
                    break;
                case 3: data.ChangeEnemyDamage();
                    popupText.text = "You're on to the next round and enemies do more damage";
                    break;
                case 4: data.ChangeMaxTimeDuration();
                    popupText.text = "You're on to the next round and you have less time to get lots of kills";
                    break;
                case 5: data.ChangeDeurToll();
                    popupText.text = "You're on to the next round and you need more coins to go through the door";
                    break;
                case 6: data.ChangeHealthContainer();
                    popupText.text = "You're on to the next round and you can earn less health from the healthpacks";
                    break;
                case 7: data.ChangeAmmoContainer();
                    popupText.text = "You're on to the next round and you can earn more ammo from the ammopacks";
                    break;
            }
            floorFall.StartRoutine();
            round.AddRound();
            doorOpen.CanBeOpenedAgain();
            for (int i = 0; i < doorsFall.Length; i++)
            {
                doorsFall[i].StartCoroutine("Reset");
            }
            for (int i = 0; i < doorTexts.Length; i++)
            {
                doorTexts[i].text = "You need: " + data.GetDeurToll() + " coins to open the door";
            }
        }
	}

    public void ResetTime()
    {
        timer.currentTime = data.GetMaxTimeDuration();
        oneTimeOnly = !oneTimeOnly;
        timer.StartCoroutine("Count");
    }

    public bool SpawnOrNot()
    {
        return oneTimeOnly;
    }
}
