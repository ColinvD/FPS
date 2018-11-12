using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairActive : MonoBehaviour {

    [SerializeField]
    private GameObject crosshair;
	
	// Update is called once per frame
	void Update () {
        if (PauseMenu.GameIsPaused)
        {
            crosshair.SetActive(false);
        } else
        {
            crosshair.SetActive(true);
        }
	}
}
