using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {
    
    public IEnumerator Falling()
    {
        Vector3 startPosition = gameObject.transform.position;
        Vector3 endPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 6, gameObject.transform.position.z);
        while (startPosition.y >= endPosition.y)
        {
            startPosition.y -= 0.2f;
            gameObject.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
            yield return new WaitForSeconds(0.1f);
        }
    }

    public IEnumerator Reset()
    {
        Vector3 startPosition = gameObject.transform.position;
        Vector3 endPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 6, gameObject.transform.position.z);
        while (startPosition.y <= endPosition.y)
        {
            startPosition.y += 0.2f;
            gameObject.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
