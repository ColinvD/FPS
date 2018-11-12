using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public bool Up()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
    }

    public bool Down()
    {
        return Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
    }

    public bool Left()
    {
        return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
    }

    public bool Right()
    {
        return Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
    }

    public float GetXRot()
    {
        return Input.GetAxis("Mouse X");
    }

    public float GetYRot()
    {
        return -Input.GetAxis("Mouse Y");
    }

    public bool LeftMouseButtonClick()
    {
        return Input.GetMouseButtonDown(0);
    }

    public bool LeftMouseButtonHold()
    {
        return Input.GetMouseButton(0);
    }

    public bool LeftMouseButtonRelease()
    {
        return Input.GetMouseButtonUp(0);
    }

    public bool Jump()
    {
        return Input.GetKey(KeyCode.Space);
    }

    public bool GetR()
    {
        return Input.GetKeyDown(KeyCode.R);
    }
    public bool Get1()
    {
        return Input.GetKeyDown(KeyCode.Alpha1);
    }
    public bool Get2()
    {
        return Input.GetKeyDown(KeyCode.Alpha2);
    }
    public bool Get3()
    {
        return Input.GetKeyDown(KeyCode.Alpha3);
    }
}
