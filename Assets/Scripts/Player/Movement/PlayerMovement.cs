using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private InputManager inputManager;
    [SerializeField]
    private float movementSpeed = 5;

	// Use this for initialization
	void Start () {
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3();
        if (inputManager.Up())
        {
            movement += transform.forward;
        }
        if (inputManager.Down())
        {
            movement -= transform.forward;
        }
        if (inputManager.Right())
        {
            movement += transform.right;
        }
        if (inputManager.Left())
        {
            movement -= transform.right;
        }
        movement.Normalize();
        transform.position += (movement * Time.deltaTime * movementSpeed);
    }
}
