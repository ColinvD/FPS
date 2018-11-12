using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    [SerializeField]
    private GameObject fallFloor;
    private ChangeValues resetTime;

    void Start()
    {
        resetTime = FindObjectOfType<ChangeValues>();
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            FallFloorActive();
            resetTime.ResetTime();
        }
    }

    public void StartRoutine()
    {
        StartCoroutine(TheFallFloor(5));
    }

	public void FallFloorActive()
    {
        fallFloor.SetActive(true);
    }

	IEnumerator TheFallFloor(int theSecondsToWait)
	{
			yield return new WaitForSeconds (theSecondsToWait);
                fallFloor.SetActive(false);
	}
} 