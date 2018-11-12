using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePanel : MonoBehaviour {

    [SerializeField]
    private GameObject openPanel;
    [SerializeField]
    private GameObject closePanel;

	public void OpenPanel()
    {
        openPanel.SetActive(true);
        closePanel.SetActive(false);
    }
}
