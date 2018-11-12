using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputRequired : MonoBehaviour {

    [SerializeField]
    private InputField inputField;
    private bool implemented = false;

    public void CheckInput()
    {
        if (inputField.text != null || inputField.text != " ")
        {
            ChangeBool();
        }
    }

    public bool GetImplemented()
    {
        return implemented;
    }

    public void ChangeBool()
    {
        implemented = !implemented;
    }
}
