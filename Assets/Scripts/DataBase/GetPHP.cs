using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPHP : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(GetValues());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator GetValues()
    {
        WWW wwwResponse = new WWW("http://22950.hosts.ma-cloud.nl/bewijzenmap/unityphp/leaderBoardFPSGet.php");

        yield return wwwResponse;
        Debug.Log(wwwResponse.text);
    }
}
