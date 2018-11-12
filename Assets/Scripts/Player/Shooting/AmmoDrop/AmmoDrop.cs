using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDrop : MonoBehaviour {

    private VariableData data;

	// Use this for initialization
	void Start () {
        data = FindObjectOfType<VariableData>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AmmoPack")
        {
            FindObjectOfType<Pistol>().addAmmoClips(data.GetAmmoContainer());
            FindObjectOfType<Burst>().addAmmoClips(data.GetAmmoContainer() + data.GetAmmoContainer()/2);
            FindObjectOfType<Automatic>().addAmmoClips(data.GetAmmoContainer() * 4);
            FindObjectOfType<AmmoAmount>().ChangeText();
            Destroy(other.gameObject);
        }
    }
}
