using UnityEngine;
using System.Collections;

public class Mrightboundary : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width-5, 0)).x, transform.position.y);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
