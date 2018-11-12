using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(JumpLogic());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator JumpLogic()
    {
        float minWaitTime = 5;
        float maxWaitTime = 10;

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            Jump();
        }
    }

    private void Jump()
    {
        float jumpSpeed = 6;
        float maxHeight = 3 + transform.position.y;
        bool jumpNow = true;
        while (jumpNow && transform.position.y < maxHeight)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpSpeed, 0);
            jumpSpeed -= 0.06f;
            jumpNow = false;
        }
    }
}
