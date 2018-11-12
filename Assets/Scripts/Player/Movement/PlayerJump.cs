using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    private InputManager inputManager;
    private bool isGrounded = false;
	// Use this for initialization
	void Start () {
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 5 * transform.localScale.y, Color.red);

        if(Physics.Raycast(ray, out hit, 7f * transform.localScale.y))
        {
            if (hit.distance >= 1.1f * transform.localScale.y)
            {
                isGrounded = false;
            } else if (hit.distance <= 1.1f * transform.localScale.y)
            {
                isGrounded = true;
            }
        }
        if (inputManager.Jump() && isGrounded)
        {
            StartCoroutine("Jumping", 100);
        }
	}

    private IEnumerator Jumping()
    {
        float jumpSpeed = 6;
        float maxHeight = 2 + transform.position.y;
        while(inputManager.Jump() && transform.position.y < maxHeight)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpSpeed, 0);
            jumpSpeed -= 0.06f * transform.localScale.y;
            yield return null;
        }
    }
}
