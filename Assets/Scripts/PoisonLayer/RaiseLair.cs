using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseLair : MonoBehaviour {
    
	private Vector3 maxPosition;
    private Vector3 minPosition;
    private bool done;

	void Start(){
        maxPosition = new Vector3(0, 28f, 0);
        minPosition = new Vector3(0, -10f, 0);
	}

    public IEnumerator Raise()
    {
        while (transform.position.y < maxPosition.y)
        {
            yield return new WaitForSeconds(0.1f);
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f + transform.position.z);
        }
        done = true;
    }

	public void Reset(){
        transform.position = minPosition;
		done = false;
	}

	public bool AreYouDone(){
        return done;
	}
}
