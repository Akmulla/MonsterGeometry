using UnityEngine;
using System.Collections;

public class DestroyOnTime : MonoBehaviour
{
    public float timeToDestroy;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(DestroyonTime());
	}

    IEnumerator DestroyonTime()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
