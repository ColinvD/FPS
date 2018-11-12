using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    private AmmoAmount ammoText;

    [SerializeField]
    private int clipSize; //amount bullets that you can have
    [SerializeField]
    private int bulletsLeft; //amount you can still shoot before you need to reload
    [SerializeField]
    private int allBullets; //all bullets

    [SerializeField]
    private FireMode firemode;
    enum FireMode {Sem,auto,burst};

    private Transform playerPosition;

    private bool going;

    void Start()
    {
        ammoText = FindObjectOfType<AmmoAmount>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public virtual void Shoot()
    {
        switch (firemode)
        {
            case FireMode.Sem:
                Shooting();
                break;
            case FireMode.auto:
                Shooting();
                break;
            case FireMode.burst:
                going = true;
                StartCoroutine("BurstShooting");
                break;
        }
    }

    private void Shooting()
    {
        if (bulletsLeft > 0)
        {
            //script to shoot
            Camera maincamera = FindObjectOfType<Camera>();
            Ray ray = new Ray(playerPosition.position, maincamera.transform.forward);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 50, Color.green);
            if (Physics.Raycast(ray, out hit, 50f))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    hit.collider.GetComponent<EnemyHealth>().LoseLife(1, "Player");
                }
            }
            bulletsLeft -= 1;
            ammoText.ChangeText();
        }
    }

    private IEnumerator BurstShooting()
    {
        int count = 0;
        while (going) {
            if (bulletsLeft > 0)
            {
                //script to shoot
                Camera maincamera = FindObjectOfType<Camera>();
                Ray ray = new Ray(playerPosition.position, maincamera.transform.forward);
                RaycastHit hit;
                Debug.DrawRay(ray.origin, ray.direction * 50, Color.green);
                if (Physics.Raycast(ray, out hit, 50f))
                {
                    if (hit.collider.gameObject.tag == "Enemy")
                    {
                        hit.collider.GetComponent<EnemyHealth>().LoseLife(1, "Player");
                    }
                }
                bulletsLeft -= 1;
                ammoText.ChangeText();
            }
            count++;
            if (count == 3)
            {
                going = false;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void Reload()
    {
        while (allBullets != 0 && bulletsLeft != clipSize)
        {
            if (allBullets != 0 && bulletsLeft != clipSize)
            {
                bulletsLeft += 1;
                allBullets -= 1;
                ammoText.ChangeText();
            }
        }
    }

    public int getClipSize()
    {
        return clipSize;
    }

    public int getBulletsLeft()
    {
        return bulletsLeft;
    }

    public float getAllBullets()
    {
        return allBullets;
    }

    public void addAmmoClips(int amount)
    {
        allBullets += amount;
    }
}
