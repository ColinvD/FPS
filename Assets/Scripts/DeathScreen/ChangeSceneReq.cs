using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneReq : MonoBehaviour {

    private InputRequired required;
    //private PHPScript phpScript;

    void Start()
    {
        required = FindObjectOfType<InputRequired>();
        //phpScript = FindObjectOfType<PHPScript>();
    }

    public void ChangingScenesReq(int index)
    {
        if (required.GetImplemented())
        {
            //phpScript.StartCoroutine("DoPHP");
            SceneManager.LoadScene(index);
        }
    }
}