using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public void ChangingScenes(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void ChangingScenesReq(int index, bool checking)
    {
        if (checking)
        {
            SceneManager.LoadScene(index);
        }
    }
}
