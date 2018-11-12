using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour{
    private bool opening = false;
    private bool opened = false;
    [SerializeField]
    private Fall[] doorOpen;
    [SerializeField]
    private KillsAmount currentKills;
    
    void Start()
    {
        doorOpen = FindObjectsOfType<Fall>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Door")
        {
            if (opened == false)
            {
                currentKills.OpenDoor();
                if (opening)
                {
                    for (int i = 0; i < doorOpen.Length; i++)
                    {
                        doorOpen[i].StartCoroutine("Falling");
                    }
                    opening = false;
                    opened = true;
                }
            }
            
          
            
        }
    }
    public void OpeningActive()
    {
        opening = true;
    }

    public void CanBeOpenedAgain()
    {
        opened = false;
    }


}
