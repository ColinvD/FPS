using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PHPScript : MonoBehaviour {

    [SerializeField]
    private Text inputName;

    private int totalKills;
    private int totalScore;
    private int totalRounds;
    private string name;
    private int playerID; //vraag silvan nog over dit

	// Use this for initialization
	void Start () {
        //StartCoroutine(DoPHP());
	}
	
    private void GetValues()
    {
        ImportantData gameData = GameObject.FindGameObjectWithTag("DBData").GetComponent<ImportantData>();
        totalKills = gameData.GetKills();
        totalScore = gameData.GetScore();
        totalRounds = gameData.GetRounds();
        Destroy(GameObject.FindGameObjectWithTag("DBData"));
        name = inputName.text;
        playerID = 18;
        //Debug.Log("kills: " + totalKills + " score: " + totalScore + " Rounds: " + totalRounds + " name: " + name + " ID: " + playerID);
    }

	public IEnumerator DoPHP()
    {
        GetValues();
        //Debug.Log("kills: " + totalKills.ToString() + " score: " + totalScore.ToString() + " Rounds: " + totalRounds.ToString() + " name: " + name.ToString() + " ID: " + playerID.ToString());
        WWW request = new WWW("http://22950.hosts.ma-cloud.nl/bewijzenmap/unityphp/leaderBoardFPS.php?" +
            "&kills=" + totalKills.ToString() +
            "&score=" + totalScore.ToString() +
            "&rounds=" + totalRounds.ToString() +
            "&name=" + name.ToString() +
            "&playerID=" + playerID.ToString()
            );
        yield return request;
        Debug.Log("Request returned");
    }
}
