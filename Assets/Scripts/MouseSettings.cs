using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSettings : MonoBehaviour {

    public static bool visible = false;

    // Use this for initialization
    void Update()
    {
        if (visible)
        {
            Cursor.visible = visible;
        }
        else
        {
            Cursor.visible = visible;
        }
    }

    public void CursorVisable()
    {
        visible = !visible;
    }
}
