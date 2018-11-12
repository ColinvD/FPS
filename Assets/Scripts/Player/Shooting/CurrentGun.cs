using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentGun : MonoBehaviour {

    private InputManager inputManager;
    private AmmoAmount ammoText;

    [SerializeField]
    private Gun weapon;
    private string weaponName;

	// Use this for initialization
	void Start () {
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
        ammoText = FindObjectOfType<AmmoAmount>();
        weapon = FindObjectOfType<Pistol>();
        weaponName = "Pistol";
	}
	
	// Update is called once per frame
	void Update () {
        if (!MouseSettings.visible)
        {
            if (inputManager.Get1())
            {
                weapon = FindObjectOfType<Pistol>();
                weaponName = "Pistol";
                ammoText.ChangeText();
            }
            if (inputManager.Get2())
            {
                weapon = FindObjectOfType<Burst>();
                weaponName = "Burst";
                ammoText.ChangeText();
            }
            if (inputManager.Get3())
            {
                weapon = FindObjectOfType<Automatic>();
                weaponName = "Automatic";
                ammoText.ChangeText();
            }
            if (weaponName == "Pistol" || weaponName == "Burst")
            {
                if (inputManager.LeftMouseButtonClick())
                {
                    weapon.Shoot();
                }
            }
            if (weaponName == "Automatic")
            {
                if (inputManager.LeftMouseButtonHold())
                {
                    weapon.Shoot();
                }
            }
            if (inputManager.GetR())
            {
                weapon.Reload();
            }
        }
    }

    public Gun GetWeapon()
    {
        return weapon;
    }
}
