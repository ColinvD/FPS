using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoAmount : MonoBehaviour {

    [SerializeField]
    private Text ammoText;
    private CurrentGun weapon;
	// Use this for initialization
	void Start () {
        weapon = FindObjectOfType<CurrentGun>();
        ChangeText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeText()
    {
        ammoText.text = weapon.GetWeapon().getBulletsLeft() + " / " + weapon.GetWeapon().getAllBullets();
    }
}
