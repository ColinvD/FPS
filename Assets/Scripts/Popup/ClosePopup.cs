using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopup : MonoBehaviour {

    [SerializeField]
    private GameObject popupScreen;
    private MouseSettings mouseSettings;

	// Use this for initialization
	void Start () {
        mouseSettings = FindObjectOfType<MouseSettings>();
	}
	
	public void Close()
    {
        mouseSettings.CursorVisable();
        Time.timeScale = 1;
        popupScreen.SetActive(false);
    }
}
