using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    private GameObject cameraObject;
    private InputManager inputManager;
    private float verticleCameraSpeed;

    [SerializeField]
    private float cameraSpeed = 5;

	// Use this for initialization
	void Start () {
        cameraObject = Camera.main.gameObject;
        if (!(inputManager = GetComponent<InputManager>()))
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (!MouseSettings.visible)
        {
            transform.Rotate(0, inputManager.GetXRot() * cameraSpeed, 0);
            verticleCameraSpeed += inputManager.GetYRot() * cameraSpeed;
            verticleCameraSpeed = Mathf.Clamp(verticleCameraSpeed, -70f, 70f);
            cameraObject.transform.localEulerAngles = new Vector3(verticleCameraSpeed, 0, 0);
        }
	}
}
